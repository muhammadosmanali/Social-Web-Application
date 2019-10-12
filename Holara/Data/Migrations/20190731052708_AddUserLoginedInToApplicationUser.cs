using Microsoft.EntityFrameworkCore.Migrations;

namespace Holara.Data.Migrations
{
    public partial class AddUserLoginedInToApplicationUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsLogedInOrNot",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsLogedInOrNot",
                table: "AspNetUsers");
        }
    }
}
