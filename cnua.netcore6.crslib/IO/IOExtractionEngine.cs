using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace CSR.IO
{
    public static class IOExtractionEngine
    {
        public const string RegexChatImportRowOfMessagePostPattern = @"17/03/2023, 20:55 - Tunde Boni: Please some of us are colour blind.. Perhaps there are other features you can employ and or deploy to describe this oscillating subject matter.";
        public const string RegexDateTimeHyphenSpacePattern = @"(\d*/\d*/\d*, \d*:\d* - )";
        public const string RegexDateTimeOnlyPattern = @"(\d*/\d*/\d*, \d*:\d*) ";
        public const string RegexDateTimeOnlyQuantPattern = @"*/\d*/\d*/\d*, \d*:\d*/* ";
        public const string RegexPostHeaderPattern = @"[0-9][0-9]/[0-9][0-9]/[0-9][0-9][0-9][0-9], [0-9][0-9]:[0-9][0-9] - ";
        public static string[] FromTextToLongRowsWithRegexForDate(string path)
        {
            using (StreamReader sr = new StreamReader(path, Encoding.Default, detectEncodingFromByteOrderMarks: true))
            {
                string str = sr.ReadToEnd();
                string[] arr = Regex.Split(str, RegexPostHeaderPattern);
                return arr;
            }
        }
    }
}
