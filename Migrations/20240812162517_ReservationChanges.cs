using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GalleryCafe.Migrations
{
    /// <inheritdoc />
    public partial class ReservationChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 9, 12, 21, 55, 17, 280, DateTimeKind.Local).AddTicks(810), new DateTime(2024, 8, 12, 21, 55, 17, 280, DateTimeKind.Local).AddTicks(790) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 9, 12, 21, 55, 17, 280, DateTimeKind.Local).AddTicks(810), new DateTime(2024, 8, 12, 21, 55, 17, 280, DateTimeKind.Local).AddTicks(810) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 9, 12, 21, 49, 59, 83, DateTimeKind.Local).AddTicks(5260), new DateTime(2024, 8, 12, 21, 49, 59, 83, DateTimeKind.Local).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 9, 12, 21, 49, 59, 83, DateTimeKind.Local).AddTicks(5260), new DateTime(2024, 8, 12, 21, 49, 59, 83, DateTimeKind.Local).AddTicks(5260) });
        }
    }
}
