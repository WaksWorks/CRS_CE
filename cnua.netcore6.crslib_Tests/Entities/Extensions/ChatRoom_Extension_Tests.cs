using Xunit;
using CSR.Entities.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSR.Entities.Extensions._Tests
{
	public class ChatRoom_Extension_Tests
	{
		/// <summary>
		/// 
		/// </summary>
		[Fact()]
		[Obsolete]
		public void ToFilteredRows_InsertPostHeaderToMultilineUserText_Test()
		{
			//arrange
			string path = @"C:\Users\cnua\source\repos\Chatroom Studio™ Community\cnua.netcore6.crslib\FS\WhatsApp Chat with TESTDATA_InsertRowHeaderToMultilineContent.txt";
			string[] lines = File.ReadAllLines(path);
			string[] filtered = lines.GetFilteredRows().ToArray();
			//act
			var expected = 29;// lines.Length = 30;
			var actual = filtered.Length;
			//assert
			Assert.True(expected == actual);

		}
	}
}