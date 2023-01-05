using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KwikKwekSnack_ClassLibary.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DrinkLines_Orders_OrderId",
                table: "DrinkLines");

            migrationBuilder.DropForeignKey(
                name: "FK_SnackLines_Orders_OrderId",
                table: "SnackLines");

            migrationBuilder.DropForeignKey(
                name: "FK_SnackLines_Snacks_SnackId",
                table: "SnackLines");

            migrationBuilder.DropTable(
                name: "ExtraSnackLine");

            migrationBuilder.DropIndex(
                name: "IX_SnackLines_SnackId",
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

            migrationBuilder.AddColumn<int>(
                name: "SnackLineId",
                table: "Extras",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                table: "Drinks",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "StartPrice" },
                values: new object[,]
                {
                    { 1, "Cola", "https://smartkiosk.nl/wp-content/uploads/2021/11/coca-cola-blik-33cl-800x800-1.jpg", "Cola", 1.50m },
                    { 2, "Fanta", "https://smartkiosk.nl/wp-content/uploads/2021/10/9480.jpg", "Fanta", 1.50m },
                    { 3, "Sprite", "https://smartkiosk.nl/wp-content/uploads/2021/09/2ad47881-f56c-4237-8574-402a84b96b63.jpg", "Sprite", 1.50m }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Status", "TotalPrice" },
                values: new object[,]
                {
                    { 1, 0, 10.00m },
                    { 2, 0, 10.00m }
                });

            migrationBuilder.InsertData(
                table: "Snacks",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "StartPrice" },
                values: new object[,]
                {
                    { 1, "Frikandel", "https://boshuis.huisjebezorgd.nl/wp-content/uploads/2020/03/29512948_652505005141152_1601506864166600704_o.jpg", "Frikandel", 2.50m },
                    { 2, "Kroket", "https://images0.persgroep.net/rcs/IFZ8aVdFNg1-Bko2qCSQg5i8G-A/diocontent/101162365/_fitwidth/763?appId=93a17a8fd81db0de025c8abd1cca1279&quality=0.8", "Kroket", 2.75m },
                    { 3, "Bamischijf", "https://veluwe-plaza.huisjebezorgd.nl/wp-content/uploads/2020/03/bami.jpg", "Bamischijf", 3.00m }
                });

            migrationBuilder.InsertData(
                table: "DrinkLines",
                columns: new[] { "Id", "DrinkId", "HasIce", "HasStraw", "OrderId", "Price", "Size", "amount" },
                values: new object[,]
                {
                    { 1, 1, false, false, 1, 3.00m, 1, 2 },
                    { 2, 2, false, true, 1, 1.50m, 2, 1 },
                    { 3, 3, false, true, 2, 1.50m, 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "SnackLines",
                columns: new[] { "Id", "OrderId", "Price", "SnackId", "amount" },
                values: new object[,]
                {
                    { 1, 1, 5.00m, 1, 2 },
                    { 2, 2, 2.75m, 2, 1 },
                    { 3, 2, 2.75m, 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "Extras",
                columns: new[] { "Id", "Name", "Price", "SnackLineId" },
                values: new object[] { 1, "Ui", 0.30m, 1 });

            migrationBuilder.InsertData(
                table: "Extras",
                columns: new[] { "Id", "Name", "Price", "SnackLineId" },
                values: new object[] { 2, "Broodje", 1.00m, 2 });

            migrationBuilder.InsertData(
                table: "Extras",
                columns: new[] { "Id", "Name", "Price", "SnackLineId" },
                values: new object[] { 3, "Tomaat", 0.20m, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Extras_SnackLineId",
                table: "Extras",
                column: "SnackLineId");

            migrationBuilder.AddForeignKey(
                name: "FK_DrinkLines_Orders_OrderId",
                table: "DrinkLines",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Extras_SnackLines_SnackLineId",
                table: "Extras",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DrinkLines_Orders_OrderId",
                table: "DrinkLines");

            migrationBuilder.DropForeignKey(
                name: "FK_Extras_SnackLines_SnackLineId",
                table: "Extras");

            migrationBuilder.DropForeignKey(
                name: "FK_SnackLines_Orders_OrderId",
                table: "SnackLines");

            migrationBuilder.DropIndex(
                name: "IX_Extras_SnackLineId",
                table: "Extras");

            migrationBuilder.DeleteData(
                table: "DrinkLines",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DrinkLines",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DrinkLines",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Snacks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Snacks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Snacks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SnackLines",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SnackLines",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SnackLines",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "SnackLineId",
                table: "Extras");

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "SnackLines",
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

            migrationBuilder.CreateTable(
                name: "ExtraSnackLine",
                columns: table => new
                {
                    ExtrasId = table.Column<int>(type: "int", nullable: false),
                    SnackLinesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtraSnackLine", x => new { x.ExtrasId, x.SnackLinesId });
                    table.ForeignKey(
                        name: "FK_ExtraSnackLine_Extras_ExtrasId",
                        column: x => x.ExtrasId,
                        principalTable: "Extras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExtraSnackLine_SnackLines_SnackLinesId",
                        column: x => x.SnackLinesId,
                        principalTable: "SnackLines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SnackLines_SnackId",
                table: "SnackLines",
                column: "SnackId");

            migrationBuilder.CreateIndex(
                name: "IX_ExtraSnackLine_SnackLinesId",
                table: "ExtraSnackLine",
                column: "SnackLinesId");

            migrationBuilder.AddForeignKey(
                name: "FK_DrinkLines_Orders_OrderId",
                table: "DrinkLines",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SnackLines_Orders_OrderId",
                table: "SnackLines",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SnackLines_Snacks_SnackId",
                table: "SnackLines",
                column: "SnackId",
                principalTable: "Snacks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
