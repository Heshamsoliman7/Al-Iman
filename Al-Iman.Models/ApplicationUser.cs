using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Al_Iman.Models
{
    public class ApplicationUser :IdentityUser
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string Nationality { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Description { get; set; }
        public DateTime DOB { get; set; }
        public string Specialist { get; set; }
        public bool IsDoctor { get; set; }
        public string PictureUri { get; set; }

        // public Department? Department { get; set; }
        public Timing Timing { get; set; }

        public ICollection<Appointment> Doctors { get; set; }

        public ICollection<Appointment> Patients { get; set; }

        //[NotMapped]
        //public ICollection<Payroll> Payrolls { get; set; }
        //[NotMapped]
        //public ICollection<PatientReport> PatientReports { get; set; }


    }
}

namespace Al_Iman.Models
{
    public enum Gender
    {
        Male,Female
    }
}