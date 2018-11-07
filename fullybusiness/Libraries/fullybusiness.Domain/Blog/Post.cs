namespace fullybusiness.Domain.Blog
{
    public class Post : BaseEntity
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public string ImageURL { get; set; }
        public string ContentText { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
    }
}