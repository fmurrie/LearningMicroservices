using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Persistence.Database.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    ProductInStockId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.ProductInStockId);
                    table.ForeignKey(
                        name: "FK_Stocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Description of Product 1", "Product 1", 590m },
                    { 73, "Description of Product 73", "Product 73", 259m },
                    { 72, "Description of Product 72", "Product 72", 117m },
                    { 71, "Description of Product 71", "Product 71", 930m },
                    { 70, "Description of Product 70", "Product 70", 927m },
                    { 69, "Description of Product 69", "Product 69", 808m },
                    { 68, "Description of Product 68", "Product 68", 605m },
                    { 67, "Description of Product 67", "Product 67", 584m },
                    { 66, "Description of Product 66", "Product 66", 190m },
                    { 65, "Description of Product 65", "Product 65", 538m },
                    { 64, "Description of Product 64", "Product 64", 750m },
                    { 63, "Description of Product 63", "Product 63", 386m },
                    { 62, "Description of Product 62", "Product 62", 895m },
                    { 61, "Description of Product 61", "Product 61", 784m },
                    { 60, "Description of Product 60", "Product 60", 331m },
                    { 59, "Description of Product 59", "Product 59", 325m },
                    { 58, "Description of Product 58", "Product 58", 792m },
                    { 57, "Description of Product 57", "Product 57", 724m },
                    { 56, "Description of Product 56", "Product 56", 686m },
                    { 55, "Description of Product 55", "Product 55", 884m },
                    { 54, "Description of Product 54", "Product 54", 676m },
                    { 53, "Description of Product 53", "Product 53", 450m },
                    { 74, "Description of Product 74", "Product 74", 644m },
                    { 52, "Description of Product 52", "Product 52", 789m },
                    { 75, "Description of Product 75", "Product 75", 505m },
                    { 77, "Description of Product 77", "Product 77", 589m },
                    { 98, "Description of Product 98", "Product 98", 664m },
                    { 97, "Description of Product 97", "Product 97", 425m },
                    { 96, "Description of Product 96", "Product 96", 755m },
                    { 95, "Description of Product 95", "Product 95", 282m },
                    { 94, "Description of Product 94", "Product 94", 341m },
                    { 93, "Description of Product 93", "Product 93", 488m },
                    { 92, "Description of Product 92", "Product 92", 643m },
                    { 91, "Description of Product 91", "Product 91", 471m },
                    { 90, "Description of Product 90", "Product 90", 261m },
                    { 89, "Description of Product 89", "Product 89", 725m },
                    { 88, "Description of Product 88", "Product 88", 310m },
                    { 87, "Description of Product 87", "Product 87", 293m },
                    { 86, "Description of Product 86", "Product 86", 947m },
                    { 85, "Description of Product 85", "Product 85", 490m },
                    { 84, "Description of Product 84", "Product 84", 449m },
                    { 83, "Description of Product 83", "Product 83", 432m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 82, "Description of Product 82", "Product 82", 404m },
                    { 81, "Description of Product 81", "Product 81", 181m },
                    { 80, "Description of Product 80", "Product 80", 509m },
                    { 79, "Description of Product 79", "Product 79", 970m },
                    { 78, "Description of Product 78", "Product 78", 928m },
                    { 76, "Description of Product 76", "Product 76", 447m },
                    { 51, "Description of Product 51", "Product 51", 710m },
                    { 50, "Description of Product 50", "Product 50", 721m },
                    { 49, "Description of Product 49", "Product 49", 139m },
                    { 22, "Description of Product 22", "Product 22", 904m },
                    { 21, "Description of Product 21", "Product 21", 159m },
                    { 20, "Description of Product 20", "Product 20", 157m },
                    { 19, "Description of Product 19", "Product 19", 612m },
                    { 18, "Description of Product 18", "Product 18", 732m },
                    { 17, "Description of Product 17", "Product 17", 732m },
                    { 16, "Description of Product 16", "Product 16", 366m },
                    { 15, "Description of Product 15", "Product 15", 123m },
                    { 14, "Description of Product 14", "Product 14", 656m },
                    { 13, "Description of Product 13", "Product 13", 216m },
                    { 12, "Description of Product 12", "Product 12", 472m },
                    { 11, "Description of Product 11", "Product 11", 734m },
                    { 10, "Description of Product 10", "Product 10", 275m },
                    { 9, "Description of Product 9", "Product 9", 851m },
                    { 8, "Description of Product 8", "Product 8", 458m },
                    { 7, "Description of Product 7", "Product 7", 367m },
                    { 6, "Description of Product 6", "Product 6", 596m },
                    { 5, "Description of Product 5", "Product 5", 479m },
                    { 4, "Description of Product 4", "Product 4", 980m },
                    { 3, "Description of Product 3", "Product 3", 395m },
                    { 2, "Description of Product 2", "Product 2", 279m },
                    { 23, "Description of Product 23", "Product 23", 554m },
                    { 24, "Description of Product 24", "Product 24", 603m },
                    { 25, "Description of Product 25", "Product 25", 755m },
                    { 26, "Description of Product 26", "Product 26", 247m },
                    { 48, "Description of Product 48", "Product 48", 507m },
                    { 47, "Description of Product 47", "Product 47", 166m },
                    { 46, "Description of Product 46", "Product 46", 345m },
                    { 45, "Description of Product 45", "Product 45", 632m },
                    { 44, "Description of Product 44", "Product 44", 626m },
                    { 43, "Description of Product 43", "Product 43", 414m },
                    { 42, "Description of Product 42", "Product 42", 712m },
                    { 41, "Description of Product 41", "Product 41", 651m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 40, "Description of Product 40", "Product 40", 967m },
                    { 39, "Description of Product 39", "Product 39", 573m },
                    { 99, "Description of Product 99", "Product 99", 188m },
                    { 38, "Description of Product 38", "Product 38", 714m },
                    { 36, "Description of Product 36", "Product 36", 195m },
                    { 35, "Description of Product 35", "Product 35", 848m },
                    { 34, "Description of Product 34", "Product 34", 610m },
                    { 33, "Description of Product 33", "Product 33", 887m },
                    { 32, "Description of Product 32", "Product 32", 644m },
                    { 31, "Description of Product 31", "Product 31", 737m },
                    { 30, "Description of Product 30", "Product 30", 201m },
                    { 29, "Description of Product 29", "Product 29", 171m },
                    { 28, "Description of Product 28", "Product 28", 471m },
                    { 27, "Description of Product 27", "Product 27", 811m },
                    { 37, "Description of Product 37", "Product 37", 435m },
                    { 100, "Description of Product 100", "Product 100", 542m }
                });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 92 },
                    { 73, 73, 9 },
                    { 72, 72, 92 },
                    { 71, 71, 18 },
                    { 70, 70, 36 },
                    { 69, 69, 95 },
                    { 68, 68, 13 },
                    { 67, 67, 84 },
                    { 66, 66, 31 },
                    { 65, 65, 3 },
                    { 64, 64, 70 },
                    { 63, 63, 41 },
                    { 62, 62, 15 },
                    { 61, 61, 26 },
                    { 60, 60, 17 },
                    { 59, 59, 5 },
                    { 58, 58, 56 },
                    { 57, 57, 76 },
                    { 56, 56, 24 },
                    { 55, 55, 49 },
                    { 54, 54, 75 },
                    { 53, 53, 13 },
                    { 74, 74, 11 },
                    { 52, 52, 40 },
                    { 75, 75, 89 },
                    { 77, 77, 18 },
                    { 98, 98, 78 },
                    { 97, 97, 6 },
                    { 96, 96, 64 },
                    { 95, 95, 72 },
                    { 94, 94, 66 },
                    { 93, 93, 23 },
                    { 92, 92, 12 },
                    { 91, 91, 10 },
                    { 90, 90, 92 },
                    { 89, 89, 39 },
                    { 88, 88, 20 },
                    { 87, 87, 34 },
                    { 86, 86, 68 },
                    { 85, 85, 88 },
                    { 84, 84, 51 },
                    { 83, 83, 65 }
                });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 82, 82, 91 },
                    { 81, 81, 87 },
                    { 80, 80, 71 },
                    { 79, 79, 13 },
                    { 78, 78, 26 },
                    { 76, 76, 29 },
                    { 51, 51, 60 },
                    { 50, 50, 40 },
                    { 49, 49, 8 },
                    { 22, 22, 67 },
                    { 21, 21, 78 },
                    { 20, 20, 69 },
                    { 19, 19, 10 },
                    { 18, 18, 94 },
                    { 17, 17, 21 },
                    { 16, 16, 87 },
                    { 15, 15, 23 },
                    { 14, 14, 12 },
                    { 13, 13, 3 },
                    { 12, 12, 79 },
                    { 11, 11, 79 },
                    { 10, 10, 12 },
                    { 9, 9, 20 },
                    { 8, 8, 34 },
                    { 7, 7, 89 },
                    { 6, 6, 81 },
                    { 5, 5, 21 },
                    { 4, 4, 20 },
                    { 3, 3, 81 },
                    { 2, 2, 84 },
                    { 23, 23, 7 },
                    { 24, 24, 24 },
                    { 25, 25, 15 },
                    { 26, 26, 4 },
                    { 48, 48, 63 },
                    { 47, 47, 16 },
                    { 46, 46, 43 },
                    { 45, 45, 11 },
                    { 44, 44, 81 },
                    { 43, 43, 49 },
                    { 42, 42, 48 },
                    { 41, 41, 80 }
                });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 40, 40, 99 },
                    { 39, 39, 84 },
                    { 99, 99, 78 },
                    { 38, 38, 28 },
                    { 36, 36, 86 },
                    { 35, 35, 17 },
                    { 34, 34, 89 },
                    { 33, 33, 95 },
                    { 32, 32, 48 },
                    { 31, 31, 9 },
                    { 30, 30, 49 },
                    { 29, 29, 92 },
                    { 28, 28, 74 },
                    { 27, 27, 54 },
                    { 37, 37, 68 },
                    { 100, 100, 80 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                table: "Stocks",
                column: "ProductId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
