using Microsoft.EntityFrameworkCore.Migrations;

namespace Cafedebug.Data.Migrations
{
    public partial class RenameColumnImagetoImageUrlEpisodie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Episode_Image_ImageId",
                table: "Episode");

            migrationBuilder.DropIndex(
                name: "IX_Episode_ImageId",
                table: "Episode");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Episode");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Episode",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Episode");

            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "Episode",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Episode_ImageId",
                table: "Episode",
                column: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Episode_Image_ImageId",
                table: "Episode",
                column: "ImageId",
                principalTable: "Image",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
