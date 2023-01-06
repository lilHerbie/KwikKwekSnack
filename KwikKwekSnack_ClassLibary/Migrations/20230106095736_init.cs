using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KwikKwekSnack_ClassLibary.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drinks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartPrice = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drinks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Extras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Extras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalPrice = table.Column<decimal>(type: "money", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Snacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartPrice = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Snacks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DrinkLines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HasStraw = table.Column<bool>(type: "bit", nullable: false),
                    HasIce = table.Column<bool>(type: "bit", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    DrinkId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrinkLines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DrinkLines_Drinks_DrinkId",
                        column: x => x.DrinkId,
                        principalTable: "Drinks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DrinkLines_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SnackLines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SnackId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SnackLines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SnackLines_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                table: "Extras",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Ui", 0.30m },
                    { 2, "Broodje", 1.00m },
                    { 3, "Tomaat", 0.20m }
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
                columns: new[] { "Id", "Amount", "DrinkId", "HasIce", "HasStraw", "OrderId", "Price", "Size" },
                values: new object[,]
                {
                    { 1, 2, 1, false, false, 1, 3.00m, 1 },
                    { 2, 1, 2, false, true, 1, 1.50m, 2 },
                    { 3, 1, 3, false, true, 2, 1.50m, 3 }
                });

            migrationBuilder.InsertData(
                table: "SnackLines",
                columns: new[] { "Id", "Amount", "OrderId", "Price", "SnackId" },
                values: new object[,]
                {
                    { 1, 2, 1, 5.00m, 1 },
                    { 2, 1, 2, 2.75m, 2 },
                    { 3, 1, 2, 2.75m, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DrinkLines_DrinkId",
                table: "DrinkLines",
                column: "DrinkId");

            migrationBuilder.CreateIndex(
                name: "IX_DrinkLines_OrderId",
                table: "DrinkLines",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_SnackLines_OrderId",
                table: "SnackLines",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DrinkLines");

            migrationBuilder.DropTable(
                name: "Extras");

            migrationBuilder.DropTable(
                name: "SnackLines");

            migrationBuilder.DropTable(
                name: "Snacks");

            migrationBuilder.DropTable(
                name: "Drinks");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
