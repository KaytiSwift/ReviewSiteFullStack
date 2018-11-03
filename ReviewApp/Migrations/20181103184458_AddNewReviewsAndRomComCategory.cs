using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewApp.Migrations
{
    public partial class AddNewReviewsAndRomComCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "RomCom" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "AltPicText", "CategoryId", "Content", "ImageURL", "Title" },
                values: new object[] { 4, "Iron Man", 3, "This movie is when the Marvel Cinematic Universe really started to come alive for me.", "/images/Guardians.jpg", "Iron Man" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "AltPicText", "CategoryId", "Content", "ImageURL", "Title" },
                values: new object[] { 5, "Holiday Calendar", 4, "This movie is your typical cliche romantic comedy but that didn't stop me from loving it.", "/images/Guardians.jpg", "The Holiday Calendar" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "AltPicText", "CategoryId", "Content", "ImageURL", "Title" },
                values: new object[] { 6, "Eternal Sunshine", 4, "One of the best movies I've ever seen! It is not a typical cliche romantic comedy and it has the best performance of Jim Carey's career.", "/images/Guardians.jpg", "Eternal Sunshine of the Spotless Mind" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
