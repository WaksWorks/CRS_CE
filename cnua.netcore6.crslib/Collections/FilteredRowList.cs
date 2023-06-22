using CSR.Entities.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CSR.Collections
{
	/// <summary>
	/// Collection filtered rows
	/// </summary>
	public class FilteredRowList: List<string>
	{
		private readonly string _filePath;
		private readonly string _jsonFile;

		public FilteredRowList(string filePath)
		{
			_filePath = filePath;
			_jsonFile = Path.ChangeExtension(_filePath, ".json");
		}
		/// <summary>
		/// load filtered Rows Collection from file.
		/// </summary>
		public void LoadOriginalText()
		{
			var lines = File.ReadAllLines(_filePath);
			var filtered = lines.GetFilteredRows().ToArray();
			this.AddRange(filtered);
		}
		public void SaveJson()
		{
			var json = JsonSerializer.Serialize(this);
			File.WriteAllText(_jsonFile, json);

		}
		public void LoadFilteredJson()
		{
			string json = File.ReadAllText(_jsonFile);
			var filtered = JsonSerializer.Deserialize<string[]>(json)!;
			this.AddRange(filtered);
		}
	}
}
