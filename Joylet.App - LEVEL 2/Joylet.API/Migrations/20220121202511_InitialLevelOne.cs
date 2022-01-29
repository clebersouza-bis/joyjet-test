using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Joylet.API.Migrations
{
    public partial class InitialLevelOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", precision: 10, scale: 2, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CartDetails = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CartsItems",
                columns: table => new
                {
                    CartId = table.Column<int>(type: "int", nullable: false),
                    ArticleId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartsItems", x => new { x.ArticleId, x.CartId });
                    table.ForeignKey(
                        name: "FK_CartsItems_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartsItems_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "water", 100m },
                    { 2, "honey", 200m },
                    { 3, "mango", 400m },
                    { 4, "tea", 1000m }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "CartDetails" },
                values: new object[,]
                {
                    { 1, "Details 1" },
                    { 2, "Details 2" },
                    { 3, "Details 3" }
                });

            migrationBuilder.InsertData(
                table: "CartsItems",
                columns: new[] { "ArticleId", "CartId", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 6 },
                    { 2, 1, 2 },
                    { 4, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 2, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartsItems_CartId",
                table: "CartsItems",
                column: "CartId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartsItems");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Carts");
        }
    }
}
