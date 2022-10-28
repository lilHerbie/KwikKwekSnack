using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KwikKwekSnack_ClassLibary.Migrations
{
    public partial class migSix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Snacks");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Drinks",
                newName: "StartPrice");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Snacks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "SnackLines",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "DrinkLines",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Snacks");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "SnackLines");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "DrinkLines");

            migrationBuilder.RenameColumn(
                name: "StartPrice",
                table: "Drinks",
                newName: "Price");

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Snacks",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
