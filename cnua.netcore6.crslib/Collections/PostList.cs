using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using CSR.Entities.Extensions;
using System.IO;
namespace CSR.Collections
{
	/// <summary>
	/// Collection of Posts
	/// </summary>
	public class PostList: List<Post>
	{
		private readonly string _filePath;
		private readonly string _jsonFile;

		//load posts from file
		public PostList(string filePath)
		{
			_filePath = filePath;
			_jsonFile = Path.ChangeExtension(_filePath, ".json");

		}
		/// <summary>
		/// load collection of posts from WhatsApp Exportfile.
		/// uses filtered Row Method
		/// </summary>
		public void LoadOriginalText()
		{
			var lines = File.ReadAllLines(_filePath);
			var filtered = lines.GetFilteredRows().ToArray();
			var posts = filtered.GetPosts().ToArray();
			this.Clear();
			this.AddRange(posts);
		}
		/// <summary>
		/// save collection of posts to json file.
		/// </summary>
		public void Save()
		{
			var json = JsonSerializer.Serialize(this);
			File.WriteAllText(_jsonFile, json);

		}
		public void Load()
		{
			string json = File.ReadAllText(_jsonFile);
			var posts = JsonSerializer.Deserialize<Post[]>(json)!;
			this.Clear();
			this.AddRange(posts);
		}
	}
}
