using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KwikKwekSnack_ClassLibary.Migrations
{
    public partial class DrinkDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Drinks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Drinks");
        }
    }
}
