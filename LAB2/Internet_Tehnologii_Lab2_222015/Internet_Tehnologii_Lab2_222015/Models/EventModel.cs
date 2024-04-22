using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Internet_Tehnologii_Lab2_222015.Models
{
    public class EventModel
    {
        public int EventID { get; set; }
        
        [Required(ErrorMessage = "Poleto e zadolzitelno")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Poleto e zadolzitelno")]
        public string Location { get; set; }

        
        public EventModel()
        {
            this.Name = "";
            this.Location = "";
            this.EventID = 0;
        }
        public EventModel(string name,string location)
        {
            this.Name = name;
            this.Location = location;
            this.EventID = 0;
        }

    }
}