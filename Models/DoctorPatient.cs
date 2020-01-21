
namespace Physician.Models
{
    public class DoctorPatient
    {
        public int DoctorId {get; set;}
        public int PatientId {get; set;}
        public int DoctorPatientId {get; set;}
        public string DoctorName {get; set;}
        public string PatientName {get; set;}
        public Doctor Doctor {get; set;}
        public Patient Patient {get; set;}
    }
}
