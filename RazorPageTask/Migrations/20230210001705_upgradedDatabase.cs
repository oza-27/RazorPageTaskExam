using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPageTask.Migrations
{
    public partial class upgradedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "categories");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "categories",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "categories",
                newName: "Description");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "categories",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }
    }
}
