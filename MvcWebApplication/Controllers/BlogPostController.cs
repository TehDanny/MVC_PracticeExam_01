using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWebApplication.Controllers
{
    public class BlogPostController : Controller
    {
        // GET: BlogPost
        public ActionResult Index()
        {
            if (Models.BlogPostRepository.GetAllBlogPosts().Count == 0)
                Models.BlogPostRepository.HardcodeBlogPosts();
            return View(Models.BlogPostRepository.GetAllBlogPosts());
        }

        // GET: BlogPost/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BlogPost/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BlogPost/Create
        [HttpPost]
        public ActionResult Create(Models.BlogPost model)
        {
            try
            {
                // TODO: Add insert logic here
                Models.BlogPostRepository.AddBlogPost(model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: BlogPost/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BlogPost/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: BlogPost/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BlogPost/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
