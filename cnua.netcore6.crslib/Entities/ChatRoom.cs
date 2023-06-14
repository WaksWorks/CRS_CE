using System.Collections.Generic;
using CSR.Entities.Extensions;

namespace CSR.Entities
{
    public class ChatRoom
    {
        public int ChatRoomId { get; set; }
        public bool IsLoaded { get; set; }
        public Guid ChatRoomGuid { get; init; } = Guid.NewGuid();
        /// <summary>
        /// relates to the export file name
        /// </summary>
        public string? ChatRoomName { get; set; }
        public string? ChatRoomPath { get; set; }
        public  IEnumerable<string>? Rows { get; set; }
        public IEnumerable<Post>? Posts { get; set; }
        public string? RawText { get; set; }
    }
}
