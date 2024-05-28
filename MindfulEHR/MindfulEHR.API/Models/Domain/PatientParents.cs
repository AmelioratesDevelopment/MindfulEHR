namespace MindfulEHR.API.Models.Domain
{
    public class PatientParents
    {
        public Guid Id { get; set; }
        public Guid PatientChartId { get; set; }
        public string MotherFirstName { get; set; }
        public string MotherLastName { get; set; }
        public string ?MotherPhoneNumber { get; set; }
        public string FatherFirstName { get; set; }
        public string FatherLastName { get; set; }
        public string ?FatherPhoneNumber { get; set; }
    }
}
