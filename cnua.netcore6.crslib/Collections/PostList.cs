using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

		//load posts from file
		public PostList(string filePath)
		{
			_filePath = filePath;
			Load();
		}
		public void Load()
		{
			var lines = File.ReadAllLines(_filePath);
			var filtered = lines.GetFilteredRows().ToArray();
			var posts = filtered.GetPosts().ToArray();
			this.AddRange(posts);
		}
		
	}
}
