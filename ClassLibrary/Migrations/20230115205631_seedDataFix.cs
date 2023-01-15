using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassLibrary.Migrations
{
    /// <inheritdoc />
    public partial class seedDataFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "ImageUrl", "Price" },
                values: new object[] { "https://goedkoopdrankslijterij.nl/image/cache/catalog/Sterke%20drank/Rum/bacardi/Bacardi-Cola-Mix-Blikjes-kopen-800x800.jpg", 3.5f });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { -6, "Stroh80", "https://static.gall.nl/images/IMG_685854_500.png?rev=0.2", "Stroh80", 5f });

            migrationBuilder.InsertData(
                table: "Snacks",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { -6, "Friet", "https://www.ahealthylife.nl/wp-content/uploads/2019/05/patat_friet_voedingswaarde.jpg", "Friet", 1.5f });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Snacks",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "ImageUrl", "Price" },
                values: new object[] { "https://www.horecagoedkoop.nl/media/catalog/product/cache/d6a5bc6be806788c48ed774973599767/b/a/bac_cola-blik.jpeg", 1.5f });
        }
    }
}
