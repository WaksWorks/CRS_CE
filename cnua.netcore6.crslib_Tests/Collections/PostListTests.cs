using Xunit;
using CSR.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSR.Collections.Tests
{
	public class PostListTests
	{
		[Fact()]
		public void LoadOriginalTextTest()
		{
			//arrange
			var path = @"C:\Users\cnua\source\repos\ChatroomStudioProto\ChatroomStudioProto\cnua.netcore6.crslibTests\Resources\WhatsApp Chat with Andy Obd.txt";
			//act
			var pl = new PostList(path);
			pl.LoadOriginalText();
			var count = pl.Count;
			pl.SaveJson();
			pl.LoadJson();
			var count2 = pl.Count;
			//assert
			Assert.True(count != count2);
		}

		[Fact()]
		public void SaveToCSVTest()
		{
			//arrange
			var path = @"C:\Users\cnua\source\repos\ChatroomStudioProto\ChatroomStudioProto\cnua.netcore6.crslibTests\Resources\WhatsApp Chat with Andy Obd.txt";
			//act
			var pl = new PostList(path);
			pl.LoadOriginalText();
			var count = pl.Count;
			pl.SaveCSV();
			var countcsv = pl.Count;
			pl.Clear();
			pl.LoadCSV();
			var count2 = pl.Count;
			//assert
			Assert.True(count == count2);
			Assert.True(count == countcsv);
		}

		[Fact()]
		public void WriteAudioPostsTest()
		{
			//arrange
			var path = @"C:\Users\cnua\source\repos\ChatroomStudioProto\ChatroomStudioProto\cnua.netcore6.crslibTests\Resources\WhatsApp Chat with Andy Obd.txt";
			//act
			var pl = new PostList(path);
			pl.LoadOriginalText();
			pl.WriteAudioPosts();
			//assert
			Assert.True(pl.Posts.Count>0);

		}
    }
}