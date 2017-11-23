using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace daniel_blog.Models
{

    public partial class PostsContext : DbContext
    {
        public virtual DbSet<PostModel> Post { get; set; }

        public PostsContext(DbContextOptions<PostsContext> options)
        : base(options)
        { }
    }



    public partial class PostModel
    {
        [Key]
        public int PostId { get; set; }
        public int BlogId { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }

    }
}
