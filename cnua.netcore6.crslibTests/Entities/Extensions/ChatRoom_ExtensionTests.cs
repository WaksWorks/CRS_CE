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
		public void GetPostFragTest()
		{
			string path = @"C:\Users\cnua\source\repos\ChatroomStudioProto\ChatroomStudioProto\cnua.netcore6.crslibTests\Resources\WhatsApp Chat with Andy Obd.txt";
			var cr = new ChatRoom();
			var fi = new FileInfo(path);
			cr.Load(fi.FullName);
			var r = cr.Rows;
			var posts = new List<Post>();
			foreach (string row in r)
			{
				(bool b, Post p) = row.GetPostFrag();
				if ((b))
				{
					posts.Add(p);
				}
			}
			Assert.True(fi.Exists);
		}

		[Fact()]
		[Obsolete]
		public void ToFilteredRowsTest()
		{
			//arrange
            string path = @"G:\My Drive\Development\ChatroomStudioProto\cnua.netcore6.crslibTests\Resources\WhatsApp Chat with TestData.txt";
			string[] lines = File.ReadAllLines(path);
			string[] filtered = lines.ToFilteredRows();
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
