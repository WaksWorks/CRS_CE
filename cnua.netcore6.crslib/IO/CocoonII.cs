using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSR.IO
{
    public struct CocoonII
    {
        private string fileTextContent;
        private string fileContentAsRows;
        private string fileContentTabulated;
        private FileInfo fileInfo;

        public string FileTextContent { get => fileTextContent; set => fileTextContent = value; }
        public string FileContentAsRows { get => fileContentAsRows; set => fileContentAsRows = value; }
        public string FileContentTabulated { get => fileContentTabulated; set => fileContentTabulated = value; }
        public FileInfo FileInfo { get => fileInfo; set => fileInfo = value; }
        public static class RegexPattern
        {
            public const string ChatRowExemplarSingleLinee = @"17/03/2023, 20:55 - Tunde Boni: Please some of us are colour blind.. Perhaps there are other features you can employ and or deploy to describe this oscillating subject matter.";
            public const string RegexDateTimeHyphenSpacePattern = @"(\d*/\d*/\d*, \d*:\d* - )";
            public const string RegexDateTimeOnlyPattern = @"(\d*/\d*/\d*, \d*:\d*) ";
            public const string RegexDateTimeOnlyQuantPattern = @"*/\d*/\d*/\d*, \d*:\d*/* ";
            public const string RegexPostHeaderPattern = @"[0-9][0-9]/[0-9][0-9]/[0-9][0-9][0-9][0-9], [0-9][0-9]:[0-9][0-9] - ";

        }
    }
}
