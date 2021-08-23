using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinic_MVC.Models
{
    public class Patients
    {


        [Key]
        public int Id { get; set; }//Primary Id
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Diseases { get; set; }
        public DateTime DateIn { get; set; }
        public DateTime DateOut { get; set; }
    }
}
