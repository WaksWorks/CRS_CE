using CSR.Entities.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSR.Collections
{
	/// <summary>
	/// filtered rows
	/// </summary>
	public class FilteredRowList: List<string>
	{
		public FilteredRowList(string filePath)
		{
			Load(filePath);
		}
		public void Load(string filePath)
		{
			var lines = File.ReadAllLines(filePath);
			var filtered = lines.GetFilteredRows().ToArray();
			this.AddRange(filtered);
		}

	}
}
