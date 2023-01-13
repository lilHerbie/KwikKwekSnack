using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassLibrary.Migrations
{
    /// <inheritdoc />
    public partial class operationDestroyDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "ExtraLines",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExtraName",
                value: "Ui");

            migrationBuilder.UpdateData(
                table: "SnackLines",
                keyColumn: "Id",
                keyValue: 1,
                column: "SnackName",
                value: "Frikandel");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SnackName",
                table: "SnackLines");

            migrationBuilder.DropColumn(
                name: "ExtraName",
                table: "ExtraLines");
        }
    }
}
