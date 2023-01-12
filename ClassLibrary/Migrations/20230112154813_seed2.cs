using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassLibrary.Migrations
{
    /// <inheritdoc />
    public partial class seed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DrinkLines_Orders_OrderId",
                table: "DrinkLines");

            migrationBuilder.DropForeignKey(
                name: "FK_ExtraLines_SnackLines_SnackLineId",
                table: "ExtraLines");

            migrationBuilder.DropForeignKey(
                name: "FK_SnackLines_Orders_OrderId",
                table: "SnackLines");

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "SnackLines",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SnackLineId",
                table: "ExtraLines",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "DrinkLines",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "ExtraLines",
                columns: new[] { "Id", "ExtraId", "SnackLineId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Status", "TotalCost" },
                values: new object[] { 1, 0, 0f });

            migrationBuilder.UpdateData(
                table: "SnackLines",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderId",
                value: 1);

            migrationBuilder.InsertData(
                table: "DrinkLines",
                columns: new[] { "Id", "DrinkId", "HasIce", "HasStraw", "OrderId" },
                values: new object[] { 1, 1, false, false, 1 });

            migrationBuilder.AddForeignKey(
                name: "FK_DrinkLines_Orders_OrderId",
                table: "DrinkLines",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExtraLines_SnackLines_SnackLineId",
                table: "ExtraLines",
                column: "SnackLineId",
                principalTable: "SnackLines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SnackLines_Orders_OrderId",
                table: "SnackLines",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DrinkLines_Orders_OrderId",
                table: "DrinkLines");

            migrationBuilder.DropForeignKey(
                name: "FK_ExtraLines_SnackLines_SnackLineId",
                table: "ExtraLines");

            migrationBuilder.DropForeignKey(
                name: "FK_SnackLines_Orders_OrderId",
                table: "SnackLines");

            migrationBuilder.DeleteData(
                table: "DrinkLines",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ExtraLines",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "SnackLines",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SnackLineId",
                table: "ExtraLines",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "DrinkLines",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "SnackLines",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderId",
                value: null);

            migrationBuilder.AddForeignKey(
                name: "FK_DrinkLines_Orders_OrderId",
                table: "DrinkLines",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExtraLines_SnackLines_SnackLineId",
                table: "ExtraLines",
                column: "SnackLineId",
                principalTable: "SnackLines",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SnackLines_Orders_OrderId",
                table: "SnackLines",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");
        }
    }
}
