using System;
using System.ComponentModel.DataAnnotations;

namespace web9.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "required r")]
        [StringLength(100, ErrorMessage = "Ten ngan qua", MinimumLength = 5)]
        [Display(Name = "Nameeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee")]
        public string Name { get; set; }
        public string Address { get; set; }
        public string Position { get; set; }
        [Required(ErrorMessage = "required r")]
        [DataType(DataType.Date)]
        public DateTime DoB { get; set; }
        [Range(100, 3000, ErrorMessage = "Luong tu 100-3000")]
        public double Salary { get; set; }

    }
}
