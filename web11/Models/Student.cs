using System;
using System.ComponentModel.DataAnnotations;

namespace web11.Models
{
    public class Student
    {
        public int Id { get; set; }
        [StringLength(9, MinimumLength = 9, ErrorMessage = "9 char")]
        [Required]
        public string StudentId { get; set; }
        [MinLength(2)]
        [Required]
        public string Name { get; set; }
        [DataType(DataType.Date)]
        [Required]
        public DateTime DoB { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Format invalid")]
        public string Email { get; set; }
        [Required]
        [Range(0,10)]
        public double Grade { get; set; }
        [Required]
        public string Image { get; set; }
    }
}
