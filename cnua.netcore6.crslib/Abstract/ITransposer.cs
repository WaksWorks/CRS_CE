using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSR.Abstract
{
	/// <summary>
	/// transform chat entry rows to posts
	/// </summary>
	internal interface ITransformer
	{
		/// <summary>
		/// transfilterate rows
		/// </summary>
		/// <param name="rows"></param>
		/// <returns></returns>
		IEnumerable<string> FilterRows(IEnumerable<string> rows);
		/// <summary>
		/// transform row to membership posts 
		/// </summary>
		/// <param name="row"></param>
		/// <returns></returns>
		Post GetPost(string row);
	}
}
