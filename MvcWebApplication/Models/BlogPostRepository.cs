using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcWebApplication.Models
{
    public class BlogPostRepository
    {
        private static List<BlogPost> blogPostList = new List<BlogPost>();
        private static object myLock = new object();

        public static void AddBlogPost(BlogPost blogpost)
        {
            lock(myLock)
            {
                blogPostList.Add(blogpost);
            }
        }

        public static List<BlogPost> GetAllBlogPosts()
        {
            lock(myLock)
            {
                return blogPostList;
            }
        }
    }
}