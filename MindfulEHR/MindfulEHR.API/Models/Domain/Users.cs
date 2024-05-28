namespace MindfulEHR.API.Models.Domain
{
    public class Users
    {
        public Guid Id { get; set; }
        public Guid UserRoleId { get; set; }
        public bool Active { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public Guid ProfileImageId { get; set; }
        public string Title { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public DateTime LastLogin { get; set; }
        public string IpOfLastLogin { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid UpdatedBy { get; set; }
        public DateTime DeletedAt { get; set; }
        public Guid DeletedBy { get; set; }

        //Navigation properties
        public UserRoles UserRole { get; set; }
        public UserPhoto UserPhoto { get; set; }
    }
}
