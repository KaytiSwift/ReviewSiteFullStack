using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewApp.Migrations
{
    public partial class AddSeedDataTagsAndReviewTags : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReviewTag",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReviewId = table.Column<int>(nullable: false),
                    TagId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReviewTag", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReviewTag_Reviews_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Reviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReviewTag_Tag_TagId",
                        column: x => x.TagId,
                        principalTable: "Tag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Tag",
                columns: new[] { "Id", "Text" },
                values: new object[,]
                {
                    { 1, "#femaleLead" },
                    { 2, "#superHeroes" },
                    { 3, "#basedOnABook" },
                    { 4, "#extraAwesome" },
                    { 5, "#comics" },
                    { 6, "#romance" },
                    { 7, "#well-acted" },
                    { 8, "#violence" }
                });

            migrationBuilder.InsertData(
                table: "ReviewTag",
                columns: new[] { "Id", "ReviewId", "TagId" },
                values: new object[,]
                {
                    { 17, 5, 1 },
                    { 11, 3, 8 },
                    { 3, 1, 8 },
                    { 30, 8, 7 },
                    { 25, 7, 7 },
                    { 22, 6, 7 },
                    { 19, 5, 7 },
                    { 15, 4, 7 },
                    { 10, 3, 7 },
                    { 6, 2, 7 },
                    { 2, 1, 7 },
                    { 29, 8, 6 },
                    { 24, 7, 6 },
                    { 21, 6, 6 },
                    { 18, 5, 6 },
                    { 14, 4, 5 },
                    { 9, 3, 5 },
                    { 1, 1, 5 },
                    { 23, 7, 4 },
                    { 20, 6, 4 },
                    { 13, 4, 4 },
                    { 8, 3, 4 },
                    { 5, 2, 4 },
                    { 28, 8, 3 },
                    { 4, 2, 3 },
                    { 12, 4, 2 },
                    { 7, 3, 2 },
                    { 27, 8, 1 },
                    { 16, 4, 8 },
                    { 26, 7, 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReviewTag_ReviewId",
                table: "ReviewTag",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewTag_TagId",
                table: "ReviewTag",
                column: "TagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReviewTag");

            migrationBuilder.DropTable(
                name: "Tag");
        }
    }
}
