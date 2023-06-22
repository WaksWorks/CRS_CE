using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using CSR.Entities.Extensions;
using System.IO;
using System.Globalization;
using System.Runtime.Serialization.Json;

namespace CSR.Collections
{
	/// <summary>
	/// Collection of Posts
	/// </summary>
	public class PostList: List<Post>
	{
		private readonly string _filePath;
		private readonly string _jsonFile;
		private readonly string _csvFile;
		public List<Post> Posts { get; set; }= new List<Post>();
		public string GetFilePath() => _filePath;
		public PostList(string filePath)
		{
			_filePath = filePath;
			_jsonFile = Path.ChangeExtension(_filePath, ".json");
			_csvFile = Path.ChangeExtension(_filePath, ".csv");
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
	}
}
