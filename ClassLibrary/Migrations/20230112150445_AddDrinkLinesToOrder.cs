using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassLibrary.Migrations
{
    /// <inheritdoc />
    public partial class AddDrinkLinesToOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "DrinkLines",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DrinkLines_OrderId",
                table: "DrinkLines",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_DrinkLines_Orders_OrderId",
                table: "DrinkLines",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DrinkLines_Orders_OrderId",
                table: "DrinkLines");

            migrationBuilder.DropIndex(
                name: "IX_DrinkLines_OrderId",
                table: "DrinkLines");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "DrinkLines");
        }
    }
}
