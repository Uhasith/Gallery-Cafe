using Microsoft.AspNetCore.Mvc;
using GalleryCafe.Models;
using GalleryCafe.Data;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace GalleryCafe.Controllers;

[Authorize]
public class MenuController : Controller
{
    private readonly AppDbContext _context;

    public MenuController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index(string searchString)
    {
        ViewData["CurrentFilter"] = searchString;

        var menuItems = _context.MenuItems.AsQueryable();

        if (!string.IsNullOrEmpty(searchString))
        {
            menuItems = menuItems
                .Where(s => s.Name.Contains(searchString) || s.CuisineType.Contains(searchString))
                .OrderBy(s => s.Name);
        }
        else
        {
            // If no search term, order all items alphabetically
            menuItems = menuItems.OrderBy(m => m.Name);
        }

        return View(menuItems.ToList());
    }
}
