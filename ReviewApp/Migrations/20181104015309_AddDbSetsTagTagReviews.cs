using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewApp.Migrations
{
    public partial class AddDbSetsTagTagReviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReviewTag_Reviews_ReviewId",
                table: "ReviewTag");

            migrationBuilder.DropForeignKey(
                name: "FK_ReviewTag_Tag_TagId",
                table: "ReviewTag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tag",
                table: "Tag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReviewTag",
                table: "ReviewTag");

            migrationBuilder.RenameTable(
                name: "Tag",
                newName: "Tags");

            migrationBuilder.RenameTable(
                name: "ReviewTag",
                newName: "ReviewTags");

            migrationBuilder.RenameIndex(
                name: "IX_ReviewTag_TagId",
                table: "ReviewTags",
                newName: "IX_ReviewTags_TagId");

            migrationBuilder.RenameIndex(
                name: "IX_ReviewTag_ReviewId",
                table: "ReviewTags",
                newName: "IX_ReviewTags_ReviewId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tags",
                table: "Tags",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReviewTags",
                table: "ReviewTags",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ReviewTags_Reviews_ReviewId",
                table: "ReviewTags",
                column: "ReviewId",
                principalTable: "Reviews",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReviewTags_Tags_TagId",
                table: "ReviewTags",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReviewTags_Reviews_ReviewId",
                table: "ReviewTags");

            migrationBuilder.DropForeignKey(
                name: "FK_ReviewTags_Tags_TagId",
                table: "ReviewTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tags",
                table: "Tags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReviewTags",
                table: "ReviewTags");

            migrationBuilder.RenameTable(
                name: "Tags",
                newName: "Tag");

            migrationBuilder.RenameTable(
                name: "ReviewTags",
                newName: "ReviewTag");

            migrationBuilder.RenameIndex(
                name: "IX_ReviewTags_TagId",
                table: "ReviewTag",
                newName: "IX_ReviewTag_TagId");

            migrationBuilder.RenameIndex(
                name: "IX_ReviewTags_ReviewId",
                table: "ReviewTag",
                newName: "IX_ReviewTag_ReviewId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tag",
                table: "Tag",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReviewTag",
                table: "ReviewTag",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ReviewTag_Reviews_ReviewId",
                table: "ReviewTag",
                column: "ReviewId",
                principalTable: "Reviews",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReviewTag_Tag_TagId",
                table: "ReviewTag",
                column: "TagId",
                principalTable: "Tag",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
