using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace GalleryCafe.Models
{
    public class MealType
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty; // e.g., "Breakfast", "Lunch", "Dinner"
        public string Description { get; set; } = string.Empty;
        public ICollection<MenuItem> MenuItems { get; set; } = new List<MenuItem>();
    }
}