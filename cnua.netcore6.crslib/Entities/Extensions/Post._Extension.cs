using Microsoft.Extensions.Hosting;
using System;

namespace CSR.Entities.Extensions
{
    public static class Post_Extension
    {
        public static string ToRow(this Post post)
        {
            var str = post.PostGuid.ToString() + @", " +
                post.TimePosted.ToString() + @" - " +
                post.MemberHandle + @": " +
                post.Message + @", ";

            return str;
        }
    }

}

