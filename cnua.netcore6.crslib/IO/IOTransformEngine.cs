using CSR.Entities.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CSR.IO
{
    public static class IOTransformEngine
    {
        public static Post[] GetPostsFromRawText(string chatroomText)
        {
            //transform raw text to chatroom lines
            string[] rows = StandardForm.GetFilteredLinesFromRawText(chatroomText);
            //transform lines to posts
            Post[] posts = StandardForm.GetPostsFromPairedRows(rows);
            return posts;
        }
        public static Post[] GetPostsFromRawText(ChatRoom chatroom)
        {
            //transform raw text to chatroom lines
            chatroom.Rows= StandardForm.GetFilteredLinesFromRawText(chatroom.ChatroomFileText);
            //transform lines to posts
            chatroom.Posts=StandardForm.GetPostsFromPairedRows(chatroom.Rows);
            return chatroom.Posts;
        }

        public static class StandardForm
        {
            /// <summary>
            /// splits the text into staggered date and content repeat array
            /// first entry is empty
            /// this routine splits textual content by date and time of post
            /// </summary>
            /// <param name="chatroomText"></param>
            /// <returns></returns>
            public static string[] GetFilteredLinesFromRawText(string chatroomText)
            {
                //@"17/03/2023, 20:55 - Tunde Boni: Please some of us are colour blind.."
                string pat = @"(\d*/\d*/\d*, \d*:\d* - )";
                Regex regex = new Regex(pat, RegexOptions.IgnoreCase);
                string[] arr = regex.Split(chatroomText);
                return arr;
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

