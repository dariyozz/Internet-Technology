using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Internet_Tehnologii_Lab3_222015.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }

        [DisplayName("Doctor Name")]
        public string Name { get; set; }
        public int HospitalId { get; set; }
        public virtual Hospital Hospital { get; set; }

        public virtual ICollection<Patient> Patients { get; set; }
        public Doctor() { }


        public Doctor(string name, int hospitalId)
        {
            Name = name;
            HospitalId = hospitalId;
        }
    }
}