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

        private async Task PopulateViewBags()
        {
            ViewBag.Tables = await _context.Tables
                .Where(t => t.IsAvailable)
                .Select(t => new { t.Id, DisplayText = "Table " + t.Id + " (Seats " + t.Capacity + ")" })
                .ToListAsync();

            ViewBag.ParkingSpots = await _context.ParkingSpots
                .Where(p => p.IsAvailable)
                .Select(p => new { p.Id, DisplayText = "Slot " + p.Id })
                .ToListAsync();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Reservation reservation, string? returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;

            var table = await _context.Tables.FindAsync(reservation.TableId);
            var parkingSpot = reservation.ParkingSpotId.HasValue
                ? await _context.ParkingSpots.FindAsync(reservation.ParkingSpotId.Value)
                : null;

            if (table != null)
            {
                reservation.Table = table;
            }

            if (parkingSpot != null)
            {
                reservation.ParkingSpot = parkingSpot;
            }

            if (ModelState.IsValid)
            {
                table.IsAvailable = false;
                if (parkingSpot != null)
                {
                    parkingSpot.IsAvailable = false;
                }

                _context.Reservations.Add(reservation);
                await _context.SaveChangesAsync();

                TempData["SuccessMessage"] = "Your reservation has been successfully made!";
                return RedirectToLocal(returnUrl);
            }

            // If ModelState is invalid, log errors to the console
            var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
            foreach (var error in errors)
            {
                Console.WriteLine($"ModelState Error: {error}");
            }

            await PopulateViewBags();
            return View(reservation);
        }

        private IActionResult RedirectToLocal(string? returnUrl)
        {
            return !string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl)
                ? Redirect(returnUrl)
                : RedirectToAction(nameof(Create));
        }

    }
}