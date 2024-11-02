using System.ComponentModel.DataAnnotations;

namespace ProductProfile.Components.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The name required")]
        [StringLength(100, ErrorMessage = "Name can´t exceed 100 characters.")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(0.01, double.MaxValue, ErrorMessage = "The price must be greater than 0")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public required string Description { get; set; }
    }
}
