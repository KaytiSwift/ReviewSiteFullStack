using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewApp.Migrations
{
    public partial class AddNewReviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "AltPicText", "CategoryId", "Content", "ImageURL", "Title" },
                values: new object[] { 7, "Avatar", 2, "This is a great movie with something for everyone.", "/images/Guardians.jpg", "Avatar" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "AltPicText", "CategoryId", "Content", "ImageURL", "Title" },
                values: new object[] { 8, "Arrival", 1, "While many people raved about how awesome this movie was and how great the ending was, I have to say that I was disappointed because I saw the ending coming from a mile away.", "/images/Guardians.jpg", "Arrival" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
