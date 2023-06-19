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
		//load posts from file
		public PostList(string filePath)
		{
			Load(filePath);
		}
		public void Load(string filePath)
		{
			var lines = File.ReadAllLines(filePath);
			var filtered = lines.GetFilteredRows().ToArray();
			var posts = filtered.GetPosts().ToArray();
			this.AddRange(posts);
		}
		
	}
}
