using Microsoft.EntityFrameworkCore;
using MindfulEHR.API.Models.Domain;

namespace MindfulEHR.API.Data
{
    public class MindfulEHRDbContext : DbContext
    {
        public MindfulEHRDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<PatientChart> PatientCharts { get; set; }
        public DbSet<PatientInsurance> PatientInsurances { get; set; }
        public DbSet<PatientParents> PatientParents { get; set; }
        public DbSet<PatientEmergencyContact> PatientEmergencyContacts { get; set; }
        public DbSet<PatientInformation> PatientInformations { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }
        public DbSet<UserPhoto> UserPhotos { get; set; }
    }
}
