namespace fullybusiness.Domain.Testimonials
{
    public class TestimonialColumn : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string AuthorLocation { get; set; }
    }
}