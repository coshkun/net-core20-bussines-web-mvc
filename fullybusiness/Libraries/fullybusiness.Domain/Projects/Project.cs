namespace fullybusiness.Domain.Projects
{
    public class Project : BaseEntity
    {
        public string ImageURL { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PageURL { get; set; }
        public int CategoryId { get; set; }
    }
}