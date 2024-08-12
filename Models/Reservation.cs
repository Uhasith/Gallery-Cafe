using System.ComponentModel.DataAnnotations;

namespace GalleryCafe.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string CustomerName { get; set; } = string.Empty;
        [Required]
        public string CustomerEmail { get; set; } = string.Empty;

        [Required]
        public int TableId { get; set; }
        public Table? Table { get; set; }

        public int? ParkingSpotId { get; set; }
        public ParkingSpot? ParkingSpot { get; set; }
    }
}