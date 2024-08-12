using System.ComponentModel.DataAnnotations;

namespace GalleryCafe.Models
{
    public class Promotion
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
    }
}
