using System.Collections.Generic;
using CSR.Collections;
using CSR.Entities.Extensions;

namespace CSR.Entities
{
	/// <summary>
	/// Chat-group record set
	/// </summary>
	public class ChatRecordSet
	{
		public int Id { get; set; }
		public bool IsLoaded { get; set; }
		public Guid RecordSetGuid { get; init; } = Guid.NewGuid();
		/// <summary>
		/// relates to the export file name
		/// </summary>
		public string? ChatGroupName { get; set; }
		public string? FilePath { get; set; }
		/// <summary>
		/// Raw Input lines
		/// </summary>
		public IEnumerable<string> InputLines { get; set; } = new List<string>();
		/// <summary>
		/// Filtered rows
		/// </summary>
		public IEnumerable<string> FilteredRows { get; set; } = new List<string>();
		/// <summary>
		/// Filtered Row List class
		/// </summary>
		public FilteredRowList? FilteredRowList { get; set; }
		/// <summary>
		/// transformed from rows
		/// </summary>
		public IEnumerable<Post> Posts { get; set; } = new List<Post>();
		/// <summary>
		/// post collection class
		/// </summary>
		public PostList? PostList { get; set; }
		/// <summary>
		/// Raw Input text
		/// </summary>
		public string? InputText { get; set; } = string.Empty;
	}
}
