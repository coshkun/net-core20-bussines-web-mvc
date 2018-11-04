namespace fullybusiness.Domain.LatestPostColumns
{
    public class LatestPostColumn : BaseEntity
    {
        public string Title { get; set; }
        public string ImageURL { get; set; }
        public string Description { get; set; }
        public string PageURL { get; set; }
        public int CommentCont { get; set; }
    }
}