using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCAssignment.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookEventEntities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    StartTime = table.Column<DateTime>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Duration = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    OtherDetails = table.Column<string>(nullable: true),
                    InviteByEmail = table.Column<string>(nullable: true),
                    Count = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CommentAdded = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookEventEntities", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookEventEntities");
        }
    }
}
