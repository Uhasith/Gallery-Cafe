using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GalleryCafe.Migrations
{
    /// <inheritdoc />
    public partial class FixedReservationTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ParkingRequired",
                table: "Reservations",
                newName: "NeedsParking");

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 9, 12, 10, 12, 3, 617, DateTimeKind.Local).AddTicks(4200), new DateTime(2024, 8, 12, 10, 12, 3, 617, DateTimeKind.Local).AddTicks(4160) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 9, 12, 10, 12, 3, 617, DateTimeKind.Local).AddTicks(4210), new DateTime(2024, 8, 12, 10, 12, 3, 617, DateTimeKind.Local).AddTicks(4210) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NeedsParking",
                table: "Reservations",
                newName: "ParkingRequired");

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 9, 12, 10, 1, 23, 700, DateTimeKind.Local).AddTicks(4250), new DateTime(2024, 8, 12, 10, 1, 23, 700, DateTimeKind.Local).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 9, 12, 10, 1, 23, 700, DateTimeKind.Local).AddTicks(4260), new DateTime(2024, 8, 12, 10, 1, 23, 700, DateTimeKind.Local).AddTicks(4260) });
        }
    }
}
