using System.ComponentModel.DataAnnotations;

namespace GalleryCafe.Models
{
    public class Table
    {
        public int Id { get; set; }
        public int Capacity { get; set; } // Number of seats at the table
        public bool IsAvailable { get; set; } = true; // Whether the table is available
    }
}