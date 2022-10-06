using System.ComponentModel.DataAnnotations;

namespace web7.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        [MinLength(1, ErrorMessage = "toi thieu 1")]
        [MaxLength(30)]
        public string Name { get; set; }
        [Range(18,23)]
        public int Age { get; set; }
        /*[EmailAddress]
        email
        [Url]
            img
        [Phone]
            phone
        [StringLength(10)]
            leng*/
    }
}
