using Xunit;
using CSR.Entities.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSR.Entities.Extensions.Tests
{
	public class ChatRoom_ExtensionTests
	{
		[Fact()]
		public void LoadTest()
		{
			string path = @"C:\Users\cnua\source\repos\ChatroomStudioProto\ChatroomStudioProto\cnua.netcore6.crslibTests\Resources\WhatsApp Chat with Andy Obd.txt";
			var cr = new ChatRoom();
			var fi = new FileInfo(path);
			cr.Load(fi.FullName);

			Assert.True(fi.Exists);
		}


		[Fact()]
		[Obsolete]
		public void InsertRowHeaderToMultilineContentTest()
		{
			//arrange
            string path = @"C:\Users\cnua\source\repos\Chatroom Studio™ Community\cnua.netcore6.crslib\FS\WhatsApp Chat with TESTDATA_InsertRowHeaderToMultilineContent.txt";
			string[] lines = File.ReadAllLines(path);
			string[] filtered = lines.InsertRowHeaderToMultilineContent();
			//act
			var expected = 29;// lines.Length = 30;
			var actual = filtered.Length;
			//assert
			Assert.True(expected == actual);
		}
    }
}

namespace cnua.netcore6.crslibTests.Entities.Extensions
{
    internal class ChatRoom_ExtensionTests
    {
    }
}
