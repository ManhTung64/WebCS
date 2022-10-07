using System;
using System.ComponentModel.DataAnnotations;
using web9.Validation;

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
        [DateValidation(ErrorMessage = "Nhap sai")]
        //[DateValidation("06/10/2022",ErrorMessage = "Nhap sai")]
        public DateTime DoB { get; set; }
        [Range(100, 3000, ErrorMessage = "Luong tu 100-3000")]
        public double Salary { get; set; }

    }
}
