namespace fullybusiness.Domain.GeneralSettings
{
    public class GeneralSetting : BaseEntity
    {
        public string SiteTitle { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public string LogoURL { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
        public string LinkedIn { get; set; }
        public string GooglePlus { get; set; }
        public string GoogleAnalytics { get; set; }
        public string GoogleMap { get; set; }
    }
}