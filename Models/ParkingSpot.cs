using System.ComponentModel.DataAnnotations;

namespace GalleryCafe.Models
{
    public class ParkingSpot
    {
        public int Id { get; set; }
        public bool IsAvailable { get; set; } = true; // Whether the parking spot is available
    }
}