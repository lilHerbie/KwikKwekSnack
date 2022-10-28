using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KwikKwekSnack_ClassLibary.Migrations
{
    public partial class migFive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExtraSnacks");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExtraSnackLine");

            migrationBuilder.CreateTable(
                name: "ExtraSnacks",
                columns: table => new
                {
                    Key = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtraSnacks", x => x.Key);
                });
        }
    }
}
