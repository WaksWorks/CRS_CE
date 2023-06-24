using CSR.Abstract;
using System;

namespace CSR.Entities
{

	/// <summary>
	/// Am single message posted in a group
	/// </summary>
	public partial class Post 
	{
		public int? PostId { get; set; }
		public Guid PostGuid { get; init; } = Guid.NewGuid();
		//public virtual ChatRecordSet? ChatRoom { get; set; }
		public DateTime? TimePosted { get; set; }
		public string? MemberHandle { get; set; }
		public string? VoiceName { get; set; }=string.Empty;
		public int VoiceRate{ get; set; } = 4;
		public string? Message { get; set; }=string.Empty;
		public string? Row { get; set; }=string.Empty;
		public PostType PostType { get; set; } = PostType.UNKNOWN;

	}

}

