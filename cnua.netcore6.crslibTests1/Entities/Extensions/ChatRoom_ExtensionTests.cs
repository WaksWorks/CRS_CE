using Xunit;
using CSR.Entities.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSR.Entities.Extensions.Tests
{
	public class ChatRoom_ExtensionTests
	{
		[Fact()]
		public void GetPostsTest()
		{
			//arrange
			string path = @"C:\Users\cnua\source\repos\ChatroomStudioProto\ChatroomStudioProto\cnua.netcore6.crslibTests\Resources\WhatsApp Chat with Andy Obd.txt";	
			var cr = new ChatRecordSet();
			var fi = new FileInfo(path);
			cr.Load(fi.FullName);
			//act
			var expected = 30;
			var actual = cr.Posts.Count();
			//assert
			Assert.True(expected == actual);

		}
	}
}