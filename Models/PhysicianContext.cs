using Microsoft.EntityFrameworkCore;

namespace Physician.Models
{
  public class PhysicianContext : DbContext
  {
    public virtual DbSet<Doctor> Doctors { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<DoctorPatient> DoctorPatient { get; set; }

    public PhysicianContext(DbContextOptions options) : base(options) { }
  }
}