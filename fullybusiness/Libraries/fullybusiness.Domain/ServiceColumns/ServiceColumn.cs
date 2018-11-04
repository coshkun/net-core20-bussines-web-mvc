namespace fullybusiness.Domain.ServiceColumns
{
    public class ServiceColumn : BaseEntity
    {
        public string Title { get; set; }
        public string ImageURL { get; set; }
        public string Description { get; set; }
        public string PageURL { get; set; }
    }
}