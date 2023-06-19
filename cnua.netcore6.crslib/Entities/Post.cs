using CSR.Abstract;
using CSR.System;
using System;

namespace CSR.Entities
{

	/// <summary>
	/// Am single message posted in a group
	/// </summary>
	public partial class Post : IPost
	{
		public int PostId { get; set; }
		public Guid PostGuid { get; init; } = Guid.NewGuid();
		public virtual ChatRecordSet? ChatRoom { get; set; }
		public DateTime? TimePosted { get; set; }
		public string? MemberHandle { get; set; }
		public string? Message { get; set; }
		public string? Row { get; set; }
		public PostType PostType { get; set; } = PostType.UNKNOWN;

	}

}

