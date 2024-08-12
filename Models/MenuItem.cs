using System.ComponentModel.DataAnnotations;

namespace GalleryCafe.Models
{
    public class MenuItem
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        [Required]
        public decimal Price { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public string CuisineType { get; set; } = string.Empty;

        public int MealTypeId { get; set; }
        public MealType MealType { get; set; }
    }
}