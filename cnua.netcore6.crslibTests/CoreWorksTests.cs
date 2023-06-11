using Xunit;
using CSR.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using cnua.netcore6.crslibTests.Properties;
using CSR.Entities;
using CSR.Entities.Extensions;
using CSR.System;

namespace CSR.Tests
{/// <summary>
/// design main spec like Rosen 
/// </summary>
    public class CoreWorksTests
    {
        string GetPath()
        {
            return @"C:\Users\cnua\source\repos\ChatroomStudioProto\ChatroomStudioProto\cnua.netcore6.crslibTests\Resources\WhatsApp Chat with TestData.txt";
        }
        [Fact()]
        public void Create_ChatroomRowsLoad_Test()
        {
            //arrange
            var cr = new ChatRoom();
            cr.Load(GetPath());
            //act
            var actual = Tuple.Create(
                cr.ChatRoomGuid.ToString(),
                cr.ChatRoomId,
                cr.ChatRoomName,
                cr.ChatRoomPath,
                cr.IsLoaded,
                cr.Rows,
                cr.Posts
                );
            //assert
            Assert.NotNull(actual);
        }
        [Fact()]
        public void Create_Chatroom_Test()
        {
            //arrange
            var cr = new ChatRoom();
            cr.Load(GetPath());
            //act
            var actual =  Tuple.Create(
                cr.ChatRoomGuid.ToString(),
                cr.ChatRoomId,
                cr.ChatRoomName,
                cr.ChatRoomPath,
                cr.IsLoaded,
                cr.Rows,
                cr.Posts
                );
            //assert
            Assert.NotNull(actual);
        }
        [Fact()]
        public void Create_PostTypeSetter_Test()
        {
            //arrange
            var cr = new ChatRoom();
            cr.Load(GetPath());
            //act
            var actual = Tuple.Create(
                cr.ChatRoomGuid.ToString(),
                cr.ChatRoomId,
                cr.ChatRoomName,
                cr.ChatRoomPath,
                cr.IsLoaded,
                cr.Rows,
                cr.Posts
                );

            //assert
            Assert.NotNull(actual);
        }

        private PostType GetPostType(this string row)
        {
            throw new NotImplementedException();
        }

        [Fact()]
        public void Create_1_Test()
        {
            //arrange
            var expected = Array.Empty<object>();
            //act
            var actual = new object();
            //assert
            Assert.True(false);
        }
        [Fact()]
        public void Create_2_Test()
        {
            //arrange
            var expected = Array.Empty<object>();
            //act
            var actual = new object();
            //assert
            Assert.True(false);
        }
    }
}