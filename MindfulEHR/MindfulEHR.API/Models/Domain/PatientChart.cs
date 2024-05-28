namespace MindfulEHR.API.Models.Domain
{
    public class PatientChart
    {
        public Guid Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime ?LastTreated { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid UpdatedBy { get; set; }
        public DateTime DeletedAt { get; set; }
        public Guid DeletedBy { get; set; }

        //Navigation properties
        public PatientInformation PatientInformation { get; set; }
        public PatientInsurance PatientInsurance { get; set; }
        public PatientParents PatientParents { get; set; }
        public PatientEmergencyContact PatientEmergencyContact { get; set; }

            

    }
}
