namespace MindfulEHR.API.Models.Domain
{
    public class UserRoles
    {
        public Guid Id { get; set; }
        public bool PatientCreate { get; set; }
        public bool PatientUpdate { get; set; }
        public bool PatientRead { get; set; }
        public bool PatientDelete { get; set; }
        public bool Reports { get; set; }
        public bool Admin { get; set; }
    }
}
