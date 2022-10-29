using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KwikKwekSnack_ClassLibary.Migrations
{
    public partial class snacklineHasExtraFeature : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExtraSnackLine");

            migrationBuilder.AddColumn<int>(
                name: "amount",
                table: "SnackLines",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "amount",
                table: "DrinkLines",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "SnackLineHasExta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    amount = table.Column<int>(type: "int", nullable: false),
                    ExtraId = table.Column<int>(type: "int", nullable: true),
                    SnackLineId = table.Column<int>(type: "int", nullable: true)
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SnackLineHasExta");

            migrationBuilder.DropColumn(
                name: "amount",
                table: "SnackLines");

            migrationBuilder.DropColumn(
                name: "amount",
                table: "DrinkLines");

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
        }
    }
}
