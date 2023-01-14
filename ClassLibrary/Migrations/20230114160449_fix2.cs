using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassLibrary.Migrations
{
    /// <inheritdoc />
    public partial class fix2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SnackName",
                table: "SnackLines");

            migrationBuilder.DropColumn(
                name: "ExtraName",
                table: "ExtraLines");

            migrationBuilder.DropColumn(
                name: "DrinkName",
                table: "DrinkLines");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SnackName",
                table: "SnackLines",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ExtraName",
                table: "ExtraLines",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DrinkName",
                table: "DrinkLines",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "DrinkLines",
                keyColumn: "Id",
                keyValue: -1,
                column: "DrinkName",
                value: "Cola");

            migrationBuilder.UpdateData(
                table: "ExtraLines",
                keyColumn: "Id",
                keyValue: -1,
                column: "ExtraName",
                value: "Ui");

            migrationBuilder.UpdateData(
                table: "SnackLines",
                keyColumn: "Id",
                keyValue: -1,
                column: "SnackName",
                value: "Frikandel");
        }
    }
}
