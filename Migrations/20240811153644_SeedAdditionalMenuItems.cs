using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GalleryCafe.Migrations
{
    /// <inheritdoc />
    public partial class SeedAdditionalMenuItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "CuisineType", "Description", "ImageUrl", "MealTypeId", "Name", "Price" },
                values: new object[,]
                {
                    { 4, "American", "Golden brown French toast", "/images/french_toast.jpg", 1, "French Toast", 6.99m },
                    { 5, "Italian", "Crispy romaine with Caesar dressing", "/images/caesar_salad.jpg", 2, "Caesar Salad", 7.99m },
                    { 6, "Thai", "Spicy and sour Thai soup", "/images/tom_yum.jpg", 3, "Tom Yum Soup", 8.99m },
                    { 7, "American", "Toasted bagel with creamy cheese", "/images/bagel.jpg", 1, "Bagel with Cream Cheese", 4.99m },
                    { 8, "French", "Classic French vegetable stew", "/images/ratatouille.jpg", 2, "Ratatouille", 9.99m },
                    { 9, "Indian", "Fragrant rice with spiced chicken", "/images/biryani.jpg", 3, "Chicken Biryani", 11.99m },
                    { 10, "American", "Crispy waffles with syrup", "/images/waffles.jpg", 1, "Waffles", 5.49m },
                    { 11, "Italian", "Layered pasta with cheese and meat", "/images/lasagna.jpg", 2, "Lasagna", 13.49m },
                    { 12, "Thai", "Stir-fried noodles with shrimp", "/images/pad_thai.jpg", 3, "Pad Thai", 10.49m },
                    { 13, "American", "Poached eggs with hollandaise sauce", "/images/eggs_benedict.jpg", 1, "Eggs Benedict", 7.99m },
                    { 14, "Italian", "Classic pizza with tomatoes and basil", "/images/margherita.jpg", 2, "Margherita Pizza", 9.49m },
                    { 15, "Indonesian", "Rich and tender slow-cooked beef", "/images/rendang.jpg", 3, "Beef Rendang", 12.99m },
                    { 16, "American", "Smashed avocado on sourdough toast", "/images/avocado_toast.jpg", 1, "Avocado Toast", 6.49m },
                    { 17, "Italian", "Pasta with creamy Alfredo sauce", "/images/fettuccine.jpg", 2, "Fettuccine Alfredo", 11.49m },
                    { 18, "Thai", "Thai green curry with chicken", "/images/green_curry.jpg", 3, "Green Curry", 9.99m }
                });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 6, 44, 599, DateTimeKind.Local).AddTicks(3940), new DateTime(2024, 8, 11, 21, 6, 44, 599, DateTimeKind.Local).AddTicks(3920) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 6, 44, 599, DateTimeKind.Local).AddTicks(3940), new DateTime(2024, 8, 11, 21, 6, 44, 599, DateTimeKind.Local).AddTicks(3940) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 9, 11, 19, 50, 10, 521, DateTimeKind.Local).AddTicks(2850), new DateTime(2024, 8, 11, 19, 50, 10, 521, DateTimeKind.Local).AddTicks(2830) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 9, 11, 19, 50, 10, 521, DateTimeKind.Local).AddTicks(2860), new DateTime(2024, 8, 11, 19, 50, 10, 521, DateTimeKind.Local).AddTicks(2850) });
        }
    }
}
