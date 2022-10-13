using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KwikKwekSnack_ClassLibary.Migrations
{
    public partial class orderupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Drinks_Orders_OrderId",
                table: "Drinks");

            migrationBuilder.DropForeignKey(
                name: "FK_Snacks_Orders_OrderId",
                table: "Snacks");

            migrationBuilder.DropIndex(
                name: "IX_Snacks_OrderId",
                table: "Snacks");

            migrationBuilder.DropIndex(
                name: "IX_Drinks_OrderId",
                table: "Drinks");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Snacks");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Drinks");

            migrationBuilder.AddColumn<int>(
                name: "DrinkId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SnackId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DrinkId",
                table: "Orders",
                column: "DrinkId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_SnackId",
                table: "Orders",
                column: "SnackId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Drinks_DrinkId",
                table: "Orders",
                column: "DrinkId",
                principalTable: "Drinks",
                principalColumn: "DrinkId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Snacks_SnackId",
                table: "Orders",
                column: "SnackId",
                principalTable: "Snacks",
                principalColumn: "SnackId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Drinks_DrinkId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Snacks_SnackId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_DrinkId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_SnackId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DrinkId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "SnackId",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Snacks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Drinks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Snacks_OrderId",
                table: "Snacks",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Drinks_OrderId",
                table: "Drinks",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Drinks_Orders_OrderId",
                table: "Drinks",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Snacks_Orders_OrderId",
                table: "Snacks",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId");
        }
    }
}
