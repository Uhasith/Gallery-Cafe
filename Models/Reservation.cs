using System.ComponentModel.DataAnnotations;

namespace GalleryCafe.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public DateTime Time { get; set; }
        [Required]
        public int NumberOfGuests { get; set; }
        [Required]
        public string CustomerName { get; set; } = string.Empty;
        [Required]
        public string CustomerEmail { get; set; } = string.Empty;
        public string SpecialRequests { get; set; } = string.Empty;
        [Required]
        public int TableCapacity { get; set; }
        [Required]
        public bool NeedsParking { get; set; } // Change the type to bool

        // References to Table and ParkingSpot
        public int? TableId { get; set; } // Nullable in case no table is available
        public Table Table { get; set; }

        public int? ParkingSpotId { get; set; } // Nullable in case no parking is needed
        public ParkingSpot ParkingSpot { get; set; }
    }
}