namespace fullybusiness.Domain.Testimonials
{
    public class Testimonial : BaseEntity
    {
        public string FullName { get; set; }
        public string Description { get; set; }
        public string CompanyName { get; set; }
        public string ImageURL { get; set; }
        public string TargetURL { get; set; }
    }
}