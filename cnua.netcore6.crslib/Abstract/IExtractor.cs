using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSR.Abstract
{/// <summary>
/// Load data from file
/// </summary>
	internal interface IExtractor
	{
		/// <summary>
		/// transform string array to posts
		/// </summary>
		/// <param name="rows"></param>
		/// <returns></returns>
		IEnumerable<Post> GetPosts(IEnumerable<string> rows);
		/// <summary>
		/// load lines from file
		/// </summary>
		/// <param name="path"></param>
		/// <returns></returns>
		IEnumerable<string> GetRows(string path);
	}
}
