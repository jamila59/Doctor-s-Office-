using System.Collections.Generic;

namespace Physician.Models
{
    public class Doctor
    {
        public Doctor()
        {   
            this.Patients = new HashSet<DoctorPatient>();
        }
        public int DoctorId {get; set;}
        public string DoctorName {get; set;}
        public ICollection<DoctorPatient> Patients {get; set;}
    }
}