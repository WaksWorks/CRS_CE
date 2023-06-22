using CSR.Collections;
using CSR.Entities;
using CsvHelper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Speech.AudioFormat;
using System.Speech.Synthesis;

namespace CSR.Entities.Extensions
{
    public static partial class Post_Entities_Extensions
    {
        public static void WriteCSV(this Post[] posts, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            using (CsvWriter csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(posts);
            }
        }
		public static void SaveToCSV(this PostList postList, string filePath)
		{
			using (StreamWriter writer = new StreamWriter(filePath))
			using (CsvWriter csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
			{
				csv.WriteRecords(postList);
			}
		}
	}
    internal static class BucketList
    {
        public const string WhatsAppExportFileFilterPattern = @"WhatsApp Chat with?.txt";
        public const string WhatsAppFileNamePrefix = @"WhatsApp Chat with ";
        public const string TextFileFilterPattern = @"?.txt";
        public const string SoundFileExtension = @".wav";
        public const string CSVFileExtension = @".csv";
    }
}