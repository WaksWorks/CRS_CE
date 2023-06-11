using CSR.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;

namespace CSR.Entities.Extensions2
{
    public static class CSR_Entities_Extensions2
    {
        public static class StandardForm
        {
            public static string[] GetRows(this ChatRoom chatroom)
            {
                throw new NotImplementedException("chatroom get not ready",);
            }
            public static string OpenText(this ChatRoom,FileInfo fileInfo)
            {
                return File.ReadAllText(fileInfo.FullName);
            }
            /// <summary>
            /// the parameter input is a staggered date and content repeater
            /// date time layer and content layer
            /// </summary>
            /// <param name="chatroomRows"></param>
            /// <returns></returns>
            public static Post[] GetPostsFromPairedRows(string[] chatroomRows)
            {
                List<Post> posts = new List<Post>();
                for (int i = 1; i <= chatroomRows.Length - 1; i += 2)
                {
                    string timeline = chatroomRows[i];
                    string contentline = chatroomRows[i + 1];
                    string strDate = timeline.Substring(0, 10);
                    string strTime = timeline.Substring(12, 5);
                    Post post = new Post
                    {
                        PostId = i,
                        TimePosted = DateTime.Parse(strDate + " " + strTime)
                    };
                    string[] contentArray = contentline.Split(':');
                    if (contentline.Length <= 1)
                    {
                        //HANDLE SYS SG ON ENCRYPT
                        posts.Add(post);
                        post.MemberHandle = @"UNKNOWN-YET";
                        break;
                    }
                    post.MemberHandle = contentArray[0];
                    post.Message = contentArray[1];
                    posts.Add(post);
                }
                return posts.ToArray<Post>();
            }
        }
    }

}

