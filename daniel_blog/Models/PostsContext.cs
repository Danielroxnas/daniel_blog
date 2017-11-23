using Microsoft.EntityFrameworkCore;

namespace daniel_blog.Models
{

    public partial class PostsContext : DbContext
    {
        public virtual DbSet<PostModel> Post { get; set; }

        public PostsContext(DbContextOptions<PostsContext> options)
        : base(options)
        { }
    }
}
