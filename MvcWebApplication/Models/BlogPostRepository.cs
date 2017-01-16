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

        internal static void HardcodeBlogPosts()
        {
            BlogPost bp1 = new BlogPost(1, "Oh my god I love this TV-series", "This show is the best!", "MLPfan2003");
            BlogPost bp2 = new BlogPost(1, "Which pony is your favorite pony?!?!", "My favorite is the one with the longest tail!", "JustAnotherFan");
            AddBlogPost(bp1);
            AddBlogPost(bp2);
        }

        public static List<BlogPost> GetAllBlogPosts()
        {
            lock(myLock)
            {
                return blogPostList;
            }
        }

        public static List<BlogPost> GetBlogPostsByAuthor(string author)
        {
            List<BlogPost> tempBlogPostList = new List<BlogPost>();
            lock (myLock)
            {
                foreach (var item in blogPostList)
                {
                    if (item.Author == author)
                        tempBlogPostList.Add(item);
                }
            }
            return tempBlogPostList;
        }
    }
}