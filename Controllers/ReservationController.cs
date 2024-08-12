using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GalleryCafe.Data;
using GalleryCafe.Models;
using System.Linq;
using System.Threading.Tasks;

namespace GalleryCafe.Controllers
{
    public class ReservationController : Controller
    {
        private readonly AppDbContext _context;

        public ReservationController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Create()
        {

            ViewBag.Tables = await _context.Tables
        .Where(t => t.IsAvailable)
        .Select(t => new
        {
            t.Id,
            DisplayText = "Table " + t.Id + " (Seats " + t.Capacity + ")"
        })
        .ToListAsync();

            ViewBag.ParkingSpots = await _context.ParkingSpots
                .Where(p => p.IsAvailable)
                .Select(p => new
                {
                    p.Id,
                    DisplayText = "Slot " + p.Id
                })
                .ToListAsync();

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                var table = await _context.Tables.FindAsync(reservation.TableId);
                var parkingSpot = reservation.ParkingSpotId.HasValue
                    ? await _context.ParkingSpots.FindAsync(reservation.ParkingSpotId.Value)
                    : null;

                if (table != null)
                {
                    table.IsAvailable = false;
                    reservation.Table = table;
                }

                if (parkingSpot != null)
                {
                    parkingSpot.IsAvailable = false;
                    reservation.ParkingSpot = parkingSpot;
                }

                _context.Reservations.Add(reservation);
                await _context.SaveChangesAsync();

                return RedirectToAction("Confirmation", new { id = reservation.Id });
            }

            ViewBag.Tables = await _context.Tables
                .Where(t => t.IsAvailable)
                .Select(t => new { t.Id, t.Capacity })
                .ToListAsync();

            ViewBag.ParkingSpots = await _context.ParkingSpots
                .Where(p => p.IsAvailable)
                .Select(p => new { p.Id })
                .ToListAsync();

            return View(reservation);
        }

        public async Task<IActionResult> Confirmation(int id)
        {
            var reservation = await _context.Reservations
                .Include(r => r.Table)
                .Include(r => r.ParkingSpot)
                .FirstOrDefaultAsync(r => r.Id == id);

            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }
    }
}