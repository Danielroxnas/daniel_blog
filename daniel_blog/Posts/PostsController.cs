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

        public ActionResult GetPost(string id)
        {
            var post = new PostModel();
            post = (from b in _context.Post
                    where b.PostId == int.Parse(id)
                    select b).First();
            return View(post);
        }

        public ActionResult GetPosts()
        {
            var posts = new List<PostModel>();
            posts = _context.Post.ToList();
            posts.Select(c => c.Content);
            return View(posts);

        }

        public void Create([FromBody] PostModel model)
        {
            _context.Post.Add(model);
            _context.SaveChanges();
        }
    }
}
