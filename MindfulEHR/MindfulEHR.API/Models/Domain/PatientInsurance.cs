namespace MindfulEHR.API.Models.Domain
{
    public class PatientInsurance
    {
        public Guid Id { get; set; }
        public Guid PatientChartId { get; set; }
        public string Type { get; set; }
        public string Provider { get; set; }
        public string GroupNumber { get; set; }
        public string PolicyNumber { get; set; }
        public string PatientNumber { get; set; }
        public string PolicyOwnerFirstName { get; set; }
        public string PolicyOwnerLastName { get; set; }
        public DateTime PolicyStartDate { get; set; }
        public DateTime PolicyEndDate { get; set; }
    }
}
