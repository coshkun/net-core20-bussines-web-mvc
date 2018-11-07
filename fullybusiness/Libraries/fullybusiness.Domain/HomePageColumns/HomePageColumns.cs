namespace fullybusiness.Domain.HomePageColumns
{
    public class HomePageColumn : BaseEntity
    {
        public string Title { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public string PageURL { get; set; }
    }
}