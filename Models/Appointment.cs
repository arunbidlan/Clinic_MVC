
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinic_MVC.Models
{
    public class Appointment
    {
     
        [Key]
        
        public int Id { get; set; }//Primary ID
        public string FirstName { get; set; }
        [Required]
        public int PatientsID { get; set; }
        public Patients Patients { get; set; }
        [Required]
        public string Diseases { get; set; }
        public DateTime DateIn { get; set; }
    }
}
