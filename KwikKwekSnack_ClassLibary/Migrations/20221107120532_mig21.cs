using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KwikKwekSnack_ClassLibary.Migrations
{
    public partial class mig21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SnackLineHasExta");

            migrationBuilder.CreateTable(
                name: "SnackLineHasExtra",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExtraId = table.Column<int>(type: "int", nullable: true),
                    SnackLineId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SnackLineHasExtra", x => x.id);
                    table.ForeignKey(
                        name: "FK_SnackLineHasExtra_Extras_ExtraId",
                        column: x => x.ExtraId,
                        principalTable: "Extras",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SnackLineHasExtra_SnackLines_SnackLineId",
                        column: x => x.SnackLineId,
                        principalTable: "SnackLines",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SnackLineHasExtra_ExtraId",
                table: "SnackLineHasExtra",
                column: "ExtraId");

            migrationBuilder.CreateIndex(
                name: "IX_SnackLineHasExtra_SnackLineId",
                table: "SnackLineHasExtra",
                column: "SnackLineId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SnackLineHasExtra");

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
        }
    }
}
