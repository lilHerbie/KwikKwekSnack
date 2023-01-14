using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClassLibrary.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drinks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false)
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false)
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
                    Status = table.Column<int>(type: "int", nullable: false),
                    TotalCost = table.Column<float>(type: "real", nullable: false)
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
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false)
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
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    DrinkName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DrinkId = table.Column<int>(type: "int", nullable: false),
                    HasStraw = table.Column<bool>(type: "bit", nullable: false),
                    HasIce = table.Column<bool>(type: "bit", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false)
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
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    SnackId = table.Column<int>(type: "int", nullable: false),
                    SnackName = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_SnackLines_Snacks_SnackId",
                        column: x => x.SnackId,
                        principalTable: "Snacks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExtraLines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExtraName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExtraId = table.Column<int>(type: "int", nullable: false),
                    SnackLineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtraLines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExtraLines_Extras_ExtraId",
                        column: x => x.ExtraId,
                        principalTable: "Extras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExtraLines_SnackLines_SnackLineId",
                        column: x => x.SnackLineId,
                        principalTable: "SnackLines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Cola", "https://smartkiosk.nl/wp-content/uploads/2021/11/coca-cola-blik-33cl-800x800-1.jpg", "Cola", 1.6f },
                    { 2, "Fanta", "https://smartkiosk.nl/wp-content/uploads/2021/10/9480.jpg", "Fanta", 1.5f },
                    { 3, "Sprite", "https://smartkiosk.nl/wp-content/uploads/2021/09/2ad47881-f56c-4237-8574-402a84b96b63.jpg", "Sprite", 1.5f }
                });

            migrationBuilder.InsertData(
                table: "Extras",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Ui", 0.3f },
                    { 2, "Broodje", 1f },
                    { 3, "Tomaat", 0.2f }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Status", "TotalCost" },
                values: new object[] { 1, 0, 0f });

            migrationBuilder.InsertData(
                table: "Snacks",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Frikandel", "https://boshuis.huisjebezorgd.nl/wp-content/uploads/2020/03/29512948_652505005141152_1601506864166600704_o.jpg", "Frikandel", 2.5f },
                    { 2, "Kroket", "https://images0.persgroep.net/rcs/IFZ8aVdFNg1-Bko2qCSQg5i8G-A/diocontent/101162365/_fitwidth/763?appId=93a17a8fd81db0de025c8abd1cca1279&quality=0.8", "Kroket", 2.75f },
                    { 3, "Bamischijf", "https://veluwe-plaza.huisjebezorgd.nl/wp-content/uploads/2020/03/bami.jpg", "Bamischijf", 3f }
                });

            migrationBuilder.InsertData(
                table: "DrinkLines",
                columns: new[] { "Id", "Amount", "DrinkId", "DrinkName", "HasIce", "HasStraw", "OrderId", "Size" },
                values: new object[] { 1, 1, 1, "Cola", false, false, 1, 0 });

            migrationBuilder.InsertData(
                table: "SnackLines",
                columns: new[] { "Id", "Amount", "OrderId", "SnackId", "SnackName" },
                values: new object[] { 1, 1, 1, 1, "Frikandel" });

            migrationBuilder.InsertData(
                table: "ExtraLines",
                columns: new[] { "Id", "ExtraId", "ExtraName", "SnackLineId" },
                values: new object[] { 1, 1, "Ui", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_DrinkLines_DrinkId",
                table: "DrinkLines",
                column: "DrinkId");

            migrationBuilder.CreateIndex(
                name: "IX_DrinkLines_OrderId",
                table: "DrinkLines",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ExtraLines_ExtraId",
                table: "ExtraLines",
                column: "ExtraId");

            migrationBuilder.CreateIndex(
                name: "IX_ExtraLines_SnackLineId",
                table: "ExtraLines",
                column: "SnackLineId");

            migrationBuilder.CreateIndex(
                name: "IX_SnackLines_OrderId",
                table: "SnackLines",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_SnackLines_SnackId",
                table: "SnackLines",
                column: "SnackId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DrinkLines");

            migrationBuilder.DropTable(
                name: "ExtraLines");

            migrationBuilder.DropTable(
                name: "Drinks");

            migrationBuilder.DropTable(
                name: "Extras");

            migrationBuilder.DropTable(
                name: "SnackLines");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Snacks");
        }
    }
}
