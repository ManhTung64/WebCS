using System.ComponentModel.DataAnnotations;

namespace web10.Models
{
    public class Product
    {
        public int Id { get; set; }
        [StringLength(20, ErrorMessage = "3 to 20 char",MinimumLength = 3)]
        public string ProductName { get; set; }
        [Range(1, 9999)]
        public double Price { get; set; }
        [Range(1,99)]
        public int Quantity { get; set; }
        [Required]
        public string Image { get; set; }
        public string Color { get; set; }

    }
}
