using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KwikKwekSnack_ClassLibary.Migrations
{
    public partial class finalHope : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DrinkLines_Drinks_DrinkID",
                table: "DrinkLines");

            migrationBuilder.DropTable(
                name: "SnackLineHasExta");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Drinks",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DrinkID",
                table: "DrinkLines",
                newName: "DrinkId");

            migrationBuilder.RenameIndex(
                name: "IX_DrinkLines_DrinkID",
                table: "DrinkLines",
                newName: "IX_DrinkLines_DrinkId");

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
                name: "IX_ExtraSnackLine_SnackLinesId",
                table: "ExtraSnackLine",
                column: "SnackLinesId");

            migrationBuilder.AddForeignKey(
                name: "FK_DrinkLines_Drinks_DrinkId",
                table: "DrinkLines",
                column: "DrinkId",
                principalTable: "Drinks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DrinkLines_Drinks_DrinkId",
                table: "DrinkLines");

            migrationBuilder.DropTable(
                name: "ExtraSnackLine");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Drinks",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "DrinkId",
                table: "DrinkLines",
                newName: "DrinkID");

            migrationBuilder.RenameIndex(
                name: "IX_DrinkLines_DrinkId",
                table: "DrinkLines",
                newName: "IX_DrinkLines_DrinkID");

            migrationBuilder.CreateTable(
                name: "SnackLineHasExta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExtraId = table.Column<int>(type: "int", nullable: true),
                    SnackLineId = table.Column<int>(type: "int", nullable: true),
                    amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SnackLineHasExta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SnackLineHasExta_Extras_ExtraId",
                        column: x => x.ExtraId,
                        principalTable: "Extras",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SnackLineHasExta_SnackLines_SnackLineId",
                        column: x => x.SnackLineId,
                        principalTable: "SnackLines",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SnackLineHasExta_ExtraId",
                table: "SnackLineHasExta",
                column: "ExtraId");

            migrationBuilder.CreateIndex(
                name: "IX_SnackLineHasExta_SnackLineId",
                table: "SnackLineHasExta",
                column: "SnackLineId");

            migrationBuilder.AddForeignKey(
                name: "FK_DrinkLines_Drinks_DrinkID",
                table: "DrinkLines",
                column: "DrinkID",
                principalTable: "Drinks",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
