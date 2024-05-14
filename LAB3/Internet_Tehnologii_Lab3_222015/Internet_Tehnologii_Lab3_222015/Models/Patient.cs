using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Internet_Tehnologii_Lab3_222015.Models
{
    public class Patient
    {
        public int PatientId { get; set; }

        [Required(ErrorMessage = "Името е задолжително.")]
        public string Name { get; set; }

        [StringLength(5)]
        [DisplayName("Код на пациентот")]
        public string PatientCode { get; set; }

        public string Gender { get; set; }
        public virtual ICollection<Doctor> Doctors { get; set; }
        
        public Patient()
        {
            Doctors = new HashSet<Doctor>();
        }

        
        public Patient(string name, string gender,string patientCode)
        {
            Name = name;
            Gender = gender;
            PatientCode = patientCode;
            Doctors = new HashSet<Doctor>();
        }
    }

}