using CSR.System;
using System;

namespace CSR.Entities
{
	public interface IPost
	{
		ChatRoom? ChatRoom { get; set; }
		string? MemberHandle { get; set; }
		string? Message { get; set; }
		Guid PostGuid { get; init; }
		int PostId { get; set; }
		PostType PostType { get; set; }
		string? Row { get; set; }
		DateTime? TimePosted { get; set; }
	}

	/// <summary>
	/// Am single message posted in a group
	/// 17/03/2023, 20:03 - +44 7960 834220: I can confirm without glasses that Lere is campaigning at something else.
	/// 17/03/2023, 20:03 - +234 805 800 0934: This message was deleted
	/// 17/03/2023, 20:04 - +234 805 800 0934: I noh blame o, Sanwo his Principal is a red chief
	/// 17/03/2023, 20:05 - Prince BOLUS: Yes he is horizontally in alliance with the campaign object..
	/// </summary>
	public partial class Post : IPost
	{
		public int PostId { get; set; }
		public Guid PostGuid { get; init; } = Guid.NewGuid();
		public virtual ChatRoom? ChatRoom { get; set; }
		public DateTime? TimePosted { get; set; }
		public string? MemberHandle { get; set; }
		public string? Message { get; set; }
		public string? Row { get; set; }
		public PostType PostType { get; set; } = PostType.UNKNOWN;

	}

}

