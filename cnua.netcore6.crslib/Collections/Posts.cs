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
	internal class Posts: List<Post>
	{
		//load posts from file
		public Posts(string filePath)
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
