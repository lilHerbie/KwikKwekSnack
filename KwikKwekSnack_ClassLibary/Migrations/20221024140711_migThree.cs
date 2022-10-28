using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KwikKwekSnack_ClassLibary.Migrations
{
    public partial class migThree : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SnackId",
                table: "SnackLines",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DrinkID",
                table: "DrinkLines",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_SnackLines_SnackId",
                table: "SnackLines",
                column: "SnackId");

            migrationBuilder.CreateIndex(
                name: "IX_DrinkLines_DrinkID",
                table: "DrinkLines",
                column: "DrinkID");

            migrationBuilder.AddForeignKey(
                name: "FK_DrinkLines_Drinks_DrinkID",
                table: "DrinkLines",
                column: "DrinkID",
                principalTable: "Drinks",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SnackLines_Snacks_SnackId",
                table: "SnackLines",
                column: "SnackId",
                principalTable: "Snacks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DrinkLines_Drinks_DrinkID",
                table: "DrinkLines");

            migrationBuilder.DropForeignKey(
                name: "FK_SnackLines_Snacks_SnackId",
                table: "SnackLines");

            migrationBuilder.DropTable(
                name: "ExtraSnacks");

            migrationBuilder.DropIndex(
                name: "IX_SnackLines_SnackId",
                table: "SnackLines");

            migrationBuilder.DropIndex(
                name: "IX_DrinkLines_DrinkID",
                table: "DrinkLines");

            migrationBuilder.DropColumn(
                name: "SnackId",
                table: "SnackLines");

            migrationBuilder.DropColumn(
                name: "DrinkID",
                table: "DrinkLines");
        }
    }
}
