using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using CSR.Entities.Extensions;
using System.IO;
using System.Globalization;
using System.Runtime.Serialization.Json;
using System.Speech.Synthesis;
using NAudio;
using NAudio.Wave;

namespace CSR.Collections
{
	/// <summary>
	/// Collection of Posts
	/// </summary>
	public class PostList : List<Post>
	{
		private readonly string _filePath;
		private readonly string _jsonFile;
		private readonly string _csvFile;
		private readonly string _wavFile;
		public List<Post> Posts { get; set; } = new List<Post>();
		public string GetFilePath() => _filePath;
		public PostList(string filePath)
		{
			_filePath = filePath;
			_jsonFile = Path.ChangeExtension(_filePath, ".json");
			_csvFile = Path.ChangeExtension(_filePath, ".csv");
			_wavFile = Path.ChangeExtension(_filePath, ".wav");
			//Posts= new List<Post>();
		}
		public void LoadOriginalText()
		{
			var lines = File.ReadAllLines(_filePath);
			var filtered = lines.GetFilteredRows().ToArray();
			var posts = filtered.GetPosts();
			//Posts= (List<Post>?)posts;
			Posts.AddRange(posts);
			this.AddRange(posts);
		}
		public void SaveJson()
		{
			var json = JsonSerializer.Serialize(Posts);
			File.WriteAllText(_jsonFile, json);
		}
		public void LoadJson()
		{
			string json = File.ReadAllText(_jsonFile);
			var posts = JsonSerializer.Deserialize<Post[]>(json)!;
			this.AddRange(posts);
		}
		public void SaveCSV()
		{
			using (StreamWriter writer = new StreamWriter(_csvFile))
			using (CsvWriter csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
			{
				csv.WriteRecords(Posts.ToArray());
			}
		}
		public void LoadCSV()
		{
			using (StreamReader reader = new StreamReader(_csvFile))
			using (CsvReader csv = new CsvReader(reader, CultureInfo.InvariantCulture))
			{
				var posts = csv.GetRecords<Post>().ToArray();
				this.AddRange(posts);
			}
		}
		/// <summary>
		/// map member handles to synth voice name and voice rate
		/// </summary>
		/// <param name="memberHandle"></param>
		/// <param name="voiceName"></param>
		/// <param name="VoiceRate"></param>
		internal void SetVoiceNames(string? memberHandle, string voiceName, int VoiceRate)
		{
			foreach (var post in Posts)
			{
				if (post.MemberHandle == memberHandle)
				{
					post.VoiceName = voiceName;
					post.VoiceRate = VoiceRate;
				}
			}
		}
		/// <summary>
		/// write audio of post to wave file
		/// </summary>
		/// <param name="post"></param>
		private void WriteAudioPost(Post post)
		{
			using (SpeechSynthesizer synth = new SpeechSynthesizer
			{
				Rate = post.VoiceRate
			})
			{
				// Configure the audio output. 
				synth.SetOutputToWaveFile(post.PostGuid.ToString().Replace("-", "_") + @".wav");
				{
					synth.SelectVoice(post.VoiceName);
					synth.Speak(post.Message);
				}
			}
		}
		/// <summary>
		/// batch write audio posts to wave files
		/// </summary>
		public void WriteAudioPosts()
		{
			AutoConfigVoices();

			foreach (var post in Posts)
			{
				WriteAudioPost(post);
			}
		}
		public void WriteAudioTranscription()
		{
			var sourceFiles = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.wav");
			var fileName = Path.GetFileNameWithoutExtension(_filePath);
			ContatenateAudioPosts(fileName, sourceFiles);

		}
		internal void ContatenateAudioPosts(string outputFile, IEnumerable<string> sourceFiles)
		{
			byte[] buffer = new byte[1024];
			WaveFileWriter? waveFileWriter = null;

			try
			{
				foreach (string sourceFile in sourceFiles)
				{
					using (WaveFileReader reader = new WaveFileReader(sourceFile))
					{
						if (waveFileWriter == null)
						{
							// first time in create new Writer
							waveFileWriter = new WaveFileWriter(outputFile, reader.WaveFormat);
						}
						else
						{
							if (!reader.WaveFormat.Equals(waveFileWriter.WaveFormat))
							{
								throw new InvalidOperationException("Can't concatenate WAV Files that don't share the same format");
							}
						}

						int read;
						while ((read = reader.Read(buffer, 0, buffer.Length)) > 0)
						{
							waveFileWriter.Write(buffer, 0, read);
						}
					}
				}
			}
			finally
			{
				if (waveFileWriter != null)
				{
					waveFileWriter.Dispose();
				}
			}

		}
		/// <summary>
		/// return list of installed voices
		/// </summary>
		/// <returns></returns>
		internal List<string> GetInstalledVoicesToList()
		{
			List<string> voices = new List<string>();
			using (SpeechSynthesizer synth = new SpeechSynthesizer())
			{
				foreach (var voice in synth.GetInstalledVoices())
				{
					VoiceInfo info = voice.VoiceInfo;
					string strId = voice.VoiceInfo.Id;
					voices.Add(voice.VoiceInfo.Name);
				}
				return voices;
			}

		}
		/// <summary>
		/// auto config voices for each member
		/// </summary>
		internal void AutoConfigVoices()
		{
			var members = Posts.Select(p => p.MemberHandle).Distinct();
			var voices = GetInstalledVoicesToList();
			var voiceCount = voices.Count();
			var memberCount = members.Count();
			var voiceIndex = 0;
			//var memberIndex = 0;
			var random = new Random();
			var rate = 0;
			foreach (var member in members)
			{
				var voiceName = voices[voiceIndex];
				rate = random.Next(1, 3);
				SetVoiceNames(member, voiceName, rate);
				voiceIndex++;
				if (voiceIndex >= voiceCount)
				{
					voiceIndex = 0;
				}
			}
		}
	}
}
