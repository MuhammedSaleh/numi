using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace numi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Dimension = table.Column<string>(type: "TEXT", nullable: false),
                    CategoryId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { "001", "Dreamy" },
                    { "002", "Sky" },
                    { "003", "Sky Pillowtop" },
                    { "004", "Aqua Memory" },
                    { "005", "Calma" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Description", "Dimension", "Name" },
                values: new object[,]
                {
                    { "01010010001", "001", "Dreamy Connected Pocket Height 23CM", "90x200", "Dreamy" },
                    { "01010010002", "001", "Dreamy Connected Pocket Height 23CM", "100x200", "Dreamy" },
                    { "01010010003", "001", "Dreamy Connected Pocket Height 23CM", "110x200", "Dreamy" },
                    { "01010010004", "001", "Dreamy Connected Pocket Height 23CM", "120x200", "Dreamy" },
                    { "01010010005", "001", "Dreamy Connected Pocket Height 23CM", "140x200", "Dreamy" },
                    { "01010010006", "001", "Dreamy Connected Pocket Height 23CM", "150x200", "Dreamy" },
                    { "01010010007", "001", "Dreamy Connected Pocket Height 23CM", "160x200", "Dreamy" },
                    { "01010010008", "001", "Dreamy Connected Pocket Height 23CM", "180x200", "Dreamy" },
                    { "01010010009", "001", "Dreamy Connected Pocket Height 23CM", "200x200", "Dreamy" },
                    { "01010020001", "002", "Sky Connected Pocket 26CM", "90x200", "Sky" },
                    { "01010020002", "002", "Sky Connected Pocket 26CM", "100x200", "Sky" },
                    { "01010020003", "002", "Sky Connected Pocket 26CM", "110x200", "Sky" },
                    { "01010020004", "002", "Sky Connected Pocket 26CM", "120x200", "Sky" },
                    { "01010020005", "002", "Sky Connected Pocket 26CM", "140x200", "Sky" },
                    { "01010020006", "002", "Sky Connected Pocket 26CM", "150x200", "Sky" },
                    { "01010020007", "002", "Sky Connected Pocket 26CM", "160x200", "Sky" },
                    { "01010020008", "002", "Sky Connected Pocket 26CM", "180x200", "Sky" },
                    { "01010020009", "002", "Sky Connected Pocket 26CM", "200x200", "Sky" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
