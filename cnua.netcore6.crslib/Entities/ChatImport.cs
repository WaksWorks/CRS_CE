using System.Collections.Generic;
using CSR.Entities.Extensions;

namespace CSR.Entities 
{
    /// <summary>
    /// A backup file extracted from a WhatsApp group chat 
    /// </summary>
    public class ChatImport
    {
        public int ChatImportId { get; set; }
        public Guid ChatImportGuid { get; set; } = new Guid();
        public ChatRecordSet? ChatRoom { get; set; }
        public virtual ICollection<string>? ChatRows { get; set; }

    }
}
