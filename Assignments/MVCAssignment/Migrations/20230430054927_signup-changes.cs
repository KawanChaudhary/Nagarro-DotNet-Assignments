using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCAssignment.Migrations
{
    public partial class signupchanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CheckPassword",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CheckPassword",
                table: "AspNetUsers");
        }
    }
}
