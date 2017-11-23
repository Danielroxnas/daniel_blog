using System.ComponentModel.DataAnnotations;

namespace daniel_blog.Models
{
    public partial class PostModel
    {
        [Key]
        public int PostId { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }
    }
}
