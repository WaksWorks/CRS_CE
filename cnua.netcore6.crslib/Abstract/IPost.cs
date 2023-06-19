using CSR.System;

namespace CSR.Abstract
{
	public interface IPost
	{
		ChatRecordSet? ChatRoom { get; set; }
		string? MemberHandle { get; set; }
		string? Message { get; set; }
		Guid PostGuid { get; init; }
		int PostId { get; set; }
		PostType PostType { get; set; }
		string? Row { get; set; }
		DateTime? TimePosted { get; set; }
	}

}

