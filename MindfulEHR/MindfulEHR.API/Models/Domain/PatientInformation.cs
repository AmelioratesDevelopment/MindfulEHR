namespace MindfulEHR.API.Models.Domain
{
    public class PatientInformation
    {
        public Guid Id { get; set; }
        public Guid PatientChartId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public string Sex { get; set; }
        public string Religion { get; set; }
        public string Citizenship { get; set; }
        public string MilitaryBranch { get; set; }
        public string Education { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
    }
}
