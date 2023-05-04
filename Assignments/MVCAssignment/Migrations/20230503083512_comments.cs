using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCAssignment.Migrations
{
    public partial class comments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
       name: "Comments",
       columns: table => new
       {
           Id = table.Column<int>(nullable: false)
               .Annotation("SqlServer:Identity", "1, 1"),
           Text = table.Column<string>(nullable: true),
           FirstName = table.Column<string>(nullable: true),
           LastName = table.Column<string>(nullable: true),
           UserId = table.Column<string>(nullable: true),
           EventId = table.Column<int>(nullable: false),
           TimeStamp = table.Column<DateTime>(nullable: false)
       },
       constraints: table =>
       {
           table.PrimaryKey("PK_Comments", x => x.Id);
       });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropTable(
                name: "Comments");
        }
    }
}
