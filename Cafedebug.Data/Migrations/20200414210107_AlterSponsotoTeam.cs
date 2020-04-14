using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cafedebug.Data.Migrations
{
    public partial class AlterSponsotoTeam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sponsor");

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", nullable: false),
                    UrlGitHub = table.Column<string>(type: "varchar(500)", nullable: false),
                    UrlInstagram = table.Column<string>(type: "varchar(500)", nullable: false),
                    UrlLinkedin = table.Column<string>(type: "varchar(500)", nullable: false),
                    UrlImage = table.Column<string>(type: "varchar(500)", nullable: false),
                    Job = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.CreateTable(
                name: "Sponsor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Bio = table.Column<string>(type: "varchar(300)", nullable: false),
                    Code = table.Column<Guid>(nullable: false),
                    ImageId = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(type: "varchar(80)", nullable: false),
                    UrlLinkedin = table.Column<string>(type: "varchar(200)", nullable: true),
                    UrlTwitter = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sponsor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sponsor_Image_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Image",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sponsor_ImageId",
                table: "Sponsor",
                column: "ImageId");
        }
    }
}
