using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Internet_Tehnologii_Lab3_222015.Models
{
    public class Hospital
    {
        public int HospitalId { get; set; }
        [DisplayName("Hospital Name")]
        public string Name { get; set; }
        public string Location { get; set; }
        public string ImageUrl { get; set; }
        public virtual ICollection<Doctor> Doctors { get; set; }


        public Hospital()
        {
            Doctors = new HashSet<Doctor>();
        }


        public Hospital(string name, string location, string imageUrl)
        {
            Name = name;
            Location = location;
            Doctors = new HashSet<Doctor>();
            ImageUrl = imageUrl;
        }
    }
}