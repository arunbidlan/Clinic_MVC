using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinic_MVC.Models
{
    public class Staff
    {
        [Key]
        public int Id { get; set; }//Primary ID
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }


    }
}
