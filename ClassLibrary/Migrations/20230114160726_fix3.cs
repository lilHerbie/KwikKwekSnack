using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassLibrary.Migrations
{
    /// <inheritdoc />
    public partial class fix3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "SnackLines");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "DrinkLines");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "TotalPrice",
                table: "SnackLines",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "TotalPrice",
                table: "DrinkLines",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.UpdateData(
                table: "DrinkLines",
                keyColumn: "Id",
                keyValue: -1,
                column: "TotalPrice",
                value: 0f);

            migrationBuilder.UpdateData(
                table: "SnackLines",
                keyColumn: "Id",
                keyValue: -1,
                column: "TotalPrice",
                value: 0f);
        }
    }
}
