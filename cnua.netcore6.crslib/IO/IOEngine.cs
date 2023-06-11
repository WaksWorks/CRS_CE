using CSR.Entities.Extensions;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Speech.AudioFormat;
using System.Speech.Synthesis;

namespace CSR.IO
{
    public static partial class IOEngine
    {
        public const string WhatsAppExportFileFilterPattern = @"WhatsApp Chat with?.txt";
        public const string WhatsAppFileNamePrefix = @"WhatsApp Chat with ";
        public const string TextFileFilterPattern = @"?.txt";
        /// <summary>
        /// get files in the current executable file location
        /// </summary>
        /// <returns>array of strings with file paths</returns>
        public static string[] GetFilePathsInCurrentDirectory()
        {
            DirectoryInfo di = new DirectoryInfo(Environment.CurrentDirectory);

            List<string> lst = new List<string>();

            foreach (FileInfo fi in di.GetFiles())
            {
                lst.Add(fi.FullName);
            }
            return lst.ToArray();
        }

        public static string[] GetFilesFromDirectoryPath(string directoryPath, string filterPattern = TextFileFilterPattern)
        {
            DirectoryInfo di = new DirectoryInfo(directoryPath);

            List<string> lst = new List<string>();

            foreach (FileInfo fi in di.GetFiles(filterPattern))
            {
                lst.Add(fi.FullName);
            }
            return lst.ToArray();
        }
        public static void WriteCsvOfPosts(Post[] posts, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            using (CsvWriter csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(posts);
            }
        }
        public static Post[] ReadCsvOfPosts(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            using (CsvReader csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                Post[] posts = csv.GetRecords<Post>().ToArray();
                return posts;
            }
        }
        public static void WritePostsCSV(FileInfo file)
        {
            string chatroomText = File.ReadAllText(file.FullName);
            string chatroomName = file.Name.Split('.')[0].Substring(WhatsAppFileNamePrefix.Length);
            var chatroom = new ChatRoom() { ChatRoomName = chatroomName, ChatroomFileText = chatroomText };
            //Post[] posts = IOTransformEngine.GetPostsFromRawText(chatroomText);
            Post[] posts = IOTransformEngine.GetPostsFromRawText(chatroom);
            string csvFile = Path.ChangeExtension(file.FullName, @".csv");
            IOEngine.WriteCsvOfPosts(posts, csvFile);
        }
        /// <summary>
        /// Heuristic file determination 
        /// perform with .txt or .csv file extension
        /// </summary>
        /// <param name="file"></param>
        public static void WritePostsCSVWave(FileInfo file)
        {
            Post[] posts = new List<Post>().ToArray();

            if (file.Extension == @".txt")
            {
                posts = IOTransformEngine.GetPostsFromRawText(File.ReadAllText(file.FullName));
                string csvFile = Path.ChangeExtension(file.FullName, @".csv");
                IOEngine.WriteCsvOfPosts(posts, csvFile);
            }

            if (file.Extension == @".csv")
            {
                posts = IOEngine.ReadCsvOfPosts(file.FullName);
            }
            string chatroomText = File.ReadAllText(file.FullName);
            string chatroomName = file.Name.Split('.')[0].Substring(WhatsAppFileNamePrefix.Length);
            var chatroom = new ChatRoom() { ChatRoomName = chatroomName, ChatroomFileText = chatroomText, Posts=posts};
            IOEngine.WritePostsWave(chatroom);
        }
        public static void WritePostsWave(Post[] posts)
        {
            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                // Configure the audio output.   
                synth.SetOutputToWaveFile(@"crs.wav",
                  new SpeechAudioFormatInfo(32000, AudioBitsPerSample.Sixteen, AudioChannel.Mono));
                // Build a prompt.  
                PromptBuilder builder = new PromptBuilder();
                var vg = VoiceGender.Male;
                /*
                 * presentation introduction
                 */
                builder.AppendText(@"Welcome to Chatroom Studio Media production of your WhatsApp Chatroom export_
                                    Software Engineering by WaksWorks of Lambeth London
                                    Copyright 2023 Wakeelu Mamudu; All rights reserved");
                builder.AppendBreak(PromptBreak.Medium);
                foreach (Post post in posts)
                {
                    vg = vg == VoiceGender.Male ? VoiceGender.Female : VoiceGender.Male;
                    synth.SelectVoiceByHints(vg, 0, 2);
                    builder.AppendText(post.Message);
                    builder.AppendBreak(PromptBreak.Medium);
                }
                // Speak the prompt.  
                synth.Speak(builder);

            }
        }
        public static void WritePostsWave(ChatRoom chatroom)
        {
            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                // Configure the audio output.   
                synth.SetOutputToWaveFile(WhatsAppFileNamePrefix + chatroom.ChatRoomName + @".wav",
                  new SpeechAudioFormatInfo(32000, AudioBitsPerSample.Sixteen, AudioChannel.Mono));
                // Build a prompt.  
                PromptBuilder builder = new PromptBuilder();
                var vg = VoiceGender.Male;
                /*
                 * presentation introduction
                 */
                builder.AppendText(@"Welcome to Chatroom Studio Media production of your WhatsApp Chatroom export_
                                    Software Engineering by WaksWorks of Lambeth London
                                    Copyright 2023 Wakeelu Mamudu; All rights reserved");
                builder.AppendBreak(PromptBreak.Medium);
                foreach (Post post in chatroom.Posts)
                {
                    vg = vg == VoiceGender.Male ? VoiceGender.Female : VoiceGender.Male;
                    synth.SelectVoiceByHints(vg, 0, 2);
                    builder.AppendText(post.Message);
                    builder.AppendBreak(PromptBreak.Medium);
                }
                // Speak the prompt.  
                synth.Speak(builder);

            }
        }
    }

}