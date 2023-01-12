using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassLibrary.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Extras_SnackLines_SnackLineId",
                table: "Extras");

            migrationBuilder.DropIndex(
                name: "IX_Extras_SnackLineId",
                table: "Extras");

            migrationBuilder.DropColumn(
                name: "SnackLineId",
                table: "Extras");

            migrationBuilder.CreateTable(
                name: "ExtraLines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExtraId = table.Column<int>(type: "int", nullable: false),
                    SnackLineId = table.Column<int>(type: "int", nullable: true)
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
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExtraLines_ExtraId",
                table: "ExtraLines",
                column: "ExtraId");

            migrationBuilder.CreateIndex(
                name: "IX_ExtraLines_SnackLineId",
                table: "ExtraLines",
                column: "SnackLineId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExtraLines");

            migrationBuilder.AddColumn<int>(
                name: "SnackLineId",
                table: "Extras",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Extras_SnackLineId",
                table: "Extras",
                column: "SnackLineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Extras_SnackLines_SnackLineId",
                table: "Extras",
                column: "SnackLineId",
                principalTable: "SnackLines",
                principalColumn: "Id");
        }
    }
}
