using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcWebApplication.Models
{
    public class BlogPost
    {
        [Required(ErrorMessage ="ID is required")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Content is required")]
        public string Content { get; set; }

        [Required(ErrorMessage = "Time of creation is required")]
        [Display(Name ="Time of creation")]
        public DateTime CreateTime { get; set; }

        [Required(ErrorMessage = "Author is required")]
        public string Author { get; set; }

        public BlogPost(int id, string title, string content, string author)
        {
            ID = id;
            Title = title;
            Content = content;
            CreateTime = DateTime.Now;
            Author = author;
        }
    }
}