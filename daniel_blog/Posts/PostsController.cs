using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using daniel_blog.Models;

namespace Blogg.Controllers
{
    //[Route("api/[controller]")]
    public class PostController : Controller
    {

        public PostController(PostsContext context)
        {
            _context = context;
        }

        private readonly PostsContext _context;

        //[HttpGet("{id}")]
        public ActionResult GetPost(string id)
        {
            var post = new PostModel();
            post = (from b in _context.Post
                    where b.PostId == int.Parse(id)
                    select b).First();
            //return JsonConvert.SerializeObject(post);
            return View(post);
        }

        //[HttpGet]
        public ActionResult GetPosts()
        {
            var posts = new List<PostModel>();
            posts = _context.Post.ToList();
            posts.Select(c => c.Content);
            //var result = JsonConvert.SerializeObject(posts);
            return View(posts);

        }

        //[HttpPost]
        public void Create([FromBody] PostModel model)
        {
            _context.Post.Add(model);
            _context.SaveChanges();
        }
    }
}
