using Xunit;
using CSR.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSR.Entities;
using CSR.Entities.Extensions;
using CsvHelper.Configuration;

namespace CSR.Collections.Tests
{
	public class ChatRoom_Extension_Tests
	{
		/// <summary>
		/// test load flag reliablity
		/// </summary>
		[Fact()]
		public void chatRecordSetLoad_Test()
		{
			//arrange
			string path = @"C:\Users\cnua\source\repos\ChatroomStudioProto\ChatroomStudioProto\cnua.netcore6.crslibTests\Resources\WhatsApp Chat with Andy Obd.txt";
			var cr = new ChatRecordSet();
			bool expected= true;
			//act
			bool beforeLoad= cr.IsLoaded;
			bool actual = cr.Load(path);
			bool afterLoad = cr.IsLoaded;
			//assert
			Assert.True(beforeLoad!=afterLoad,"beforeLoad != afterLoad");
			Assert.True(expected == actual, "expected is actual for Load Method");
		}
		[Fact()]
		public void LoadOriginalTextTest()
		{
			//arrange
			string path = @"C:\Users\cnua\source\repos\ChatroomStudioProto\ChatroomStudioProto\cnua.netcore6.crslibTests\Resources\WhatsApp Chat with Andy Obd.txt";
			var cr = new ChatRecordSet();
			bool expected = true;
			//act
			bool beforeLoad = cr.IsLoaded;
			bool actual = cr.Load(path);
			bool afterLoad = cr.IsLoaded;
			//assert
			Assert.True(beforeLoad != afterLoad, "beforeLoad != afterLoad");
			Assert.True(expected == actual, "expected is actual for Load Method");
		}
	}
}