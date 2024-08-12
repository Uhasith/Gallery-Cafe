using System.ComponentModel.DataAnnotations;

namespace GalleryCafe.Models
{
    public class PreOrderItem
    {
        public int Id { get; set; }

        public int MenuItemId { get; set; }
        [Required]
        public MenuItem MenuItem { get; set; }

        [Required]
        public int Quantity { get; set; }

        public string SpecialInstructions { get; set; } = string.Empty;

        // Foreign key to PreOrder
        public int PreOrderId { get; set; }
        public PreOrder PreOrder { get; set; }
    }
}