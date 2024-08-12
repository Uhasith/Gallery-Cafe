using System.ComponentModel.DataAnnotations;

namespace GalleryCafe.Models
{
    public class PreOrder
    {
        public int Id { get; set; }
        public int ReservationId { get; set; }
        [Required]
        public Reservation Reservation { get; set; }
        public ICollection<PreOrderItem> PreOrderItems { get; set; } = new List<PreOrderItem>();
    }
}