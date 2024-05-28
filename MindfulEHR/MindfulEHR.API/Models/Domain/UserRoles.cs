namespace MindfulEHR.API.Models.Domain
{
    public class UserRoles
    {
        public Guid Id { get; set; }
        public bool ProductsCreate { get; set; }
        public bool ProductsUpdate { get; set; }
        public bool ProductsRead { get; set; }
        public bool ProductsDelete { get; set; }
        public bool Reports { get; set; }
        public bool Admin { get; set; }
    }
}
