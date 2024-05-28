namespace MindfulEHR.API.Models.Domain
{
    public class PatientEmergencyContact
    {
        public Guid Id { get; set; }
        public Guid PatientChartId { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ?Sex { get; set; }
        public string ?AddressLine1 { get; set; }
        public string ?AddressLine2 { get; set; }
        public string ?State { get; set; }
        public string ?City { get; set; }
        public string ?Zip { get; set; }
        public string RelationshipToClient { get; set; }
        public string ?EmailAddress { get; set; }
        public string Phone { get; set; }
    }
}
