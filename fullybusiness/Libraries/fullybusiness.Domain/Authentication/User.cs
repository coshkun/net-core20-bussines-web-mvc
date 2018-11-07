namespace fullybusiness.Domain.Authentication
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string ImageURL { get; set; }
        public string Biography { get; set; }
    }
}