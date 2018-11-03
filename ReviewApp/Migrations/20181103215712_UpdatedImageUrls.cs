using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewApp.Migrations
{
    public partial class UpdatedImageUrls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageURL",
                value: "/images/IronMan.jpg");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageURL",
                value: "/images/HolidayCalendar.jpg");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageURL",
                value: "/images/EternalSunshine.jpg");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageURL",
                value: "/images/Avatar.jpg");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageURL",
                value: "/images/Arrival.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageURL",
                value: "/images/Guardians.jpg");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageURL",
                value: "/images/Guardians.jpg");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageURL",
                value: "/images/Guardians.jpg");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageURL",
                value: "/images/Guardians.jpg");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageURL",
                value: "/images/Guardians.jpg");
        }
    }
}
