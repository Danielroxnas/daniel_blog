using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using daniel_blog.Models;

namespace Blogg.Controllers
{
    public class PostsController : Controller
    {

        public PostsController(PostsContext context)
        {
            _context = context;
        }

        private readonly PostsContext _context;

        public ActionResult GetPost(string id) => View(_context.Post.Where(x => x.PostId == int.Parse(id)).First());

        public ActionResult GetPosts() => View(_context.Post.ToList().OrderBy(x => x.PostId));

        [HttpGet]
        public ActionResult Create() => View();

        [HttpPost]
        public ActionResult Create(string title, string content)
        {
  
            //var context = new PostModel
            //{
            //    Title = title,
            //    Content = content,
            //    Date = DateTime.Now
            //};
            //_context.Post.Add(context);
            //_context.SaveChanges();
            return RedirectToAction(nameof(GetPosts));
        }
    }
}
