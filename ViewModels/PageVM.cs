using Microsoft.Build.Framework;

namespace Blog.ViewModels
{
    public class PageVM
    {
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        public string? ShortDescription { get; set; }
        public string? Description { get; set; }
        public string? Slug { get; set;}
        public string? PhotoUrl { get; set; }
        public IFormFile? PhotoFormFile { get; set; }
    }
}
