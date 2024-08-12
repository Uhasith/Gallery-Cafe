using GalleryCafe.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GalleryCafe.Data;

public class AppDbContext : IdentityDbContext<AppUser>
{
    public DbSet<MealType> MealTypes { get; set; }
    public DbSet<MenuItem> MenuItems { get; set; }
    public DbSet<Promotion> Promotions { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<PreOrder> PreOrders { get; set; }
    public DbSet<PreOrderItem> PreOrderItems { get; set; }
    public DbSet<Table> Tables { get; set; } 
    public DbSet<ParkingSpot> ParkingSpots { get; set; } 

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<PreOrderItem>()
          .HasOne(p => p.PreOrder)
          .WithMany(po => po.PreOrderItems)
          .HasForeignKey(p => p.PreOrderId);

        // Seeding MealTypes
        modelBuilder.Entity<MealType>().HasData(
            new MealType { Id = 1, Name = "Breakfast", Description = "Morning meals" },
            new MealType { Id = 2, Name = "Lunch", Description = "Midday meals" },
            new MealType { Id = 3, Name = "Dinner", Description = "Evening meals" }
        );

        // Seeding MenuItems
        modelBuilder.Entity<MenuItem>().HasData(
            new MenuItem { Id = 1, Name = "Pancakes", Description = "Fluffy pancakes", Price = 5.99M, ImageUrl = "/images/pancakes.jpg", CuisineType = "American", MealTypeId = 1 },
            new MenuItem { Id = 2, Name = "Spaghetti", Description = "Classic Italian pasta", Price = 12.99M, ImageUrl = "/images/spaghetti.jpg", CuisineType = "Italian", MealTypeId = 2 },
            new MenuItem { Id = 3, Name = "Chicken Curry", Description = "Spicy Sri Lankan curry", Price = 10.99M, ImageUrl = "/images/chicken_curry.jpg", CuisineType = "Sri Lankan", MealTypeId = 3 },
            new MenuItem { Id = 4, Name = "French Toast", Description = "Golden brown French toast", Price = 6.99M, ImageUrl = "/images/french_toast.jpg", CuisineType = "American", MealTypeId = 1 },
            new MenuItem { Id = 5, Name = "Caesar Salad", Description = "Crispy romaine with Caesar dressing", Price = 7.99M, ImageUrl = "/images/caesar_salad.jpg", CuisineType = "Italian", MealTypeId = 2 },
            new MenuItem { Id = 6, Name = "Tom Yum Soup", Description = "Spicy and sour Thai soup", Price = 8.99M, ImageUrl = "/images/tom_yum.jpg", CuisineType = "Thai", MealTypeId = 3 },
            new MenuItem { Id = 7, Name = "Bagel with Cream Cheese", Description = "Toasted bagel with creamy cheese", Price = 4.99M, ImageUrl = "/images/bagel.jpg", CuisineType = "American", MealTypeId = 1 },
            new MenuItem { Id = 8, Name = "Ratatouille", Description = "Classic French vegetable stew", Price = 9.99M, ImageUrl = "/images/ratatouille.jpg", CuisineType = "French", MealTypeId = 2 },
            new MenuItem { Id = 9, Name = "Chicken Biryani", Description = "Fragrant rice with spiced chicken", Price = 11.99M, ImageUrl = "/images/biryani.jpg", CuisineType = "Indian", MealTypeId = 3 },
            new MenuItem { Id = 10, Name = "Waffles", Description = "Crispy waffles with syrup", Price = 5.49M, ImageUrl = "/images/waffles.jpg", CuisineType = "American", MealTypeId = 1 },
            new MenuItem { Id = 11, Name = "Lasagna", Description = "Layered pasta with cheese and meat", Price = 13.49M, ImageUrl = "/images/lasagna.jpg", CuisineType = "Italian", MealTypeId = 2 },
            new MenuItem { Id = 12, Name = "Pad Thai", Description = "Stir-fried noodles with shrimp", Price = 10.49M, ImageUrl = "/images/pad_thai.jpg", CuisineType = "Thai", MealTypeId = 3 },
            new MenuItem { Id = 13, Name = "Eggs Benedict", Description = "Poached eggs with hollandaise sauce", Price = 7.99M, ImageUrl = "/images/eggs_benedict.jpg", CuisineType = "American", MealTypeId = 1 },
            new MenuItem { Id = 14, Name = "Margherita Pizza", Description = "Classic pizza with tomatoes and basil", Price = 9.49M, ImageUrl = "/images/margherita.jpg", CuisineType = "Italian", MealTypeId = 2 },
            new MenuItem { Id = 15, Name = "Beef Rendang", Description = "Rich and tender slow-cooked beef", Price = 12.99M, ImageUrl = "/images/rendang.jpg", CuisineType = "Indonesian", MealTypeId = 3 },
            new MenuItem { Id = 16, Name = "Avocado Toast", Description = "Smashed avocado on sourdough toast", Price = 6.49M, ImageUrl = "/images/avocado_toast.jpg", CuisineType = "American", MealTypeId = 1 },
            new MenuItem { Id = 17, Name = "Fettuccine Alfredo", Description = "Pasta with creamy Alfredo sauce", Price = 11.49M, ImageUrl = "/images/fettuccine.jpg", CuisineType = "Italian", MealTypeId = 2 },
            new MenuItem { Id = 18, Name = "Green Curry", Description = "Thai green curry with chicken", Price = 9.99M, ImageUrl = "/images/green_curry.jpg", CuisineType = "Thai", MealTypeId = 3 }
        );

        // Seeding Promotions
        modelBuilder.Entity<Promotion>().HasData(
            new Promotion { Id = 1, Title = "Summer Special", Description = "50% off on all desserts", StartDate = DateTime.Now, EndDate = DateTime.Now.AddMonths(1), ImageUrl = "/images/summer_special.jpg" },
            new Promotion { Id = 2, Title = "Happy Hour", Description = "Buy 1 Get 1 Free on cocktails", StartDate = DateTime.Now, EndDate = DateTime.Now.AddMonths(1), ImageUrl = "/images/happy_hour.jpg" }
        );

        // Seed data for tables and parking spots
        modelBuilder.Entity<Table>().HasData(
            new Table { Id = 1, Capacity = 4, IsAvailable = true },
            new Table { Id = 2, Capacity = 4, IsAvailable = true },
            new Table { Id = 3, Capacity = 5, IsAvailable = true },
            new Table { Id = 4, Capacity = 5, IsAvailable = true },
            new Table { Id = 5, Capacity = 5, IsAvailable = true }
        );

        modelBuilder.Entity<ParkingSpot>().HasData(
            new ParkingSpot { Id = 1, IsAvailable = true },
            new ParkingSpot { Id = 2, IsAvailable = true },
            new ParkingSpot { Id = 3, IsAvailable = true },
            new ParkingSpot { Id = 4, IsAvailable = true },
            new ParkingSpot { Id = 5, IsAvailable = true }
        );
    }
}
