using CSR.Entities;
using System.IO;

namespace CSR.IO
{
    public struct Cocoon
    {
        private readonly Post[] posts;

        public Cocoon(string filePath) : this()
        {
            FileInfo = new FileInfo(filePath);
            ChatRoom = new ChatRoom() { ChatRoomName = FileInfo.Name.Substring(14) };
            FileTextContent = File.ReadAllText(filePath);
            FileContentAsRows = File.ReadAllLines(filePath);
            posts = IOTransformEngine.GetPostsFromRawText(File.ReadAllText(filePath));
        }
        public ChatRoom ChatRoom { get; }
        public ExportFile ChatImport { get; }
        public Post[] Posts => posts;
        public string FileTextContent { get; set; }
        public string[] FileContentAsRows { get; set; }
        public string FileContentTabulated { get; set; }
        public FileInfo FileInfo { get; set; }
        public struct RegexPattern
        {
            public const string WhatsAppExportFileNameExtention = @".txt";
            public const string WhatsAppExportFileNameTemplate = @"WhatsApp Chat";
            public const string ChatRowExemplarSingleLinee = @"17/03/2023, 20:55 - Tunde Boni: Please some of us are colour blind.. Perhaps there are other features you can employ and or deploy to describe this oscillating subject matter.";
            public const string RegexDateTimeHyphenSpacePattern = @"(\d*/\d*/\d*, \d*:\d* - )";
            public const string RegexDateTimeOnlyPattern = @"(\d*/\d*/\d*, \d*:\d*) ";
            public const string RegexDateTimeOnlyQuantPattern = @"*/\d*/\d*/\d*, \d*:\d*/* ";
            public const string RegexPostHeaderPattern = @"[0-9][0-9]/[0-9][0-9]/[0-9][0-9][0-9][0-9], [0-9][0-9]:[0-9][0-9] - ";

        }
    }
}
