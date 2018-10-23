using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewApp.Migrations
{
    public partial class AddedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "AltPicText", "Content", "ImageURL", "ReviewCategory", "Title" },
                values: new object[] { 1, "Venom", "The critics said this movie sucked! I haven't seen it yet but Neko said it was awesome! I guess I need to go see it myself.", "/images/Venom.jpg", "Action", "Venom" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "AltPicText", "Content", "ImageURL", "ReviewCategory", "Title" },
                values: new object[] { 2, "Harry Potter", "Best movie EVER!!! Based on the best book series ever! I love this movie. Go watch it if you haven't.", "/images/HarryPotter.jpg", "Fantasy", "Harry Potter and the Philosopher's Stone" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "AltPicText", "Content", "ImageURL", "ReviewCategory", "Title" },
                values: new object[] { 3, "Guardians", "Hilarious! A must see movie! High quality writing just like every other MCU movie. If they don't make a third one, my heart will break.", "/images/Guardians.jpg", "Sci-Fi", "Guardians of the Galaxy" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
