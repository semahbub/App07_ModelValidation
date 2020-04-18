using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App07_ModelValidation.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name="Employee Name")]
        public string Name { get; set; }

        [Required, MinLength(5)]
        public string Designation { get; set; }

        [Required]
        public string Department { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required, DataType(DataType.Date), Display(Name="Date of Joining")]
        public DateTime JoiningDate { get; set; }

        [Required, DataType(DataType.Date), Display(Name = "Date of Birth")]
        public DateTime BirthDate { get; set; }   

        [Range(0, 300000)]
        public double BasicSalary { get; set; }

        [Required]
        public bool IsEligibleforBonus { get; set; }

        [Required]
        [MinLength(3)]
        public string Grade { get; set; }

        public bool IsPartTime { get; set; }

        [Url]
        public string Website { get; set; }
    }
}
