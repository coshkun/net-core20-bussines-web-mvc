namespace fullybusiness.Domain.Partners
{
    public class Partner : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public string TargetURL { get; set; }
    }
}