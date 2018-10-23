using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewApp.Migrations
{
    public partial class AddedCategoryIdAndCategoryProps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReviewCategory",
                table: "Reviews");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Reviews",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CategoryId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CategoryId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CategoryId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CategoryId",
                table: "Reviews",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Categories_CategoryId",
                table: "Reviews",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Categories_CategoryId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_CategoryId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Reviews");

            migrationBuilder.AddColumn<string>(
                name: "ReviewCategory",
                table: "Reviews",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReviewCategory",
                value: "Action");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReviewCategory",
                value: "Fantasy");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReviewCategory",
                value: "Sci-Fi");
        }
    }
}
