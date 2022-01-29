using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Joylet.API.Migrations
{
    public partial class LevelTwoFeesAndDiscount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DeliveryFeesId",
                table: "Carts",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Articles",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)",
                oldPrecision: 10,
                oldScale: 2);

            migrationBuilder.CreateTable(
                name: "DeliveryFees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MinPrice = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    MaxPrice = table.Column<decimal>(type: "decimal(65,30)", nullable: true),
                    DeliveryPrice = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsExpired = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryFees", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsExpired = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ArticleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Discounts_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "DeliveryFees",
                columns: new[] { "Id", "DeliveryPrice", "IsActive", "IsExpired", "MaxPrice", "MinPrice" },
                values: new object[,]
                {
                    { 1, 800m, true, false, 1000m, 0m },
                    { 2, 400m, true, false, 2000m, 1000m },
                    { 3, 0m, true, false, null, 4000m }
                });

            migrationBuilder.InsertData(
                table: "Discounts",
                columns: new[] { "Id", "ArticleId", "IsActive", "IsExpired", "Type", "Value" },
                values: new object[,]
                {
                    { 1, 2, true, false, "amount", 25m },
                    { 2, 5, true, false, "percentage", 30m },
                    { 3, 6, true, false, "percentage", 30m },
                    { 4, 7, true, false, "percentage", 25m },
                    { 5, 8, true, false, "percentage", 10m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carts_DeliveryFeesId",
                table: "Carts",
                column: "DeliveryFeesId");

            migrationBuilder.CreateIndex(
                name: "IX_Discounts_ArticleId",
                table: "Discounts",
                column: "ArticleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_DeliveryFees_DeliveryFeesId",
                table: "Carts",
                column: "DeliveryFeesId",
                principalTable: "DeliveryFees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_DeliveryFees_DeliveryFeesId",
                table: "Carts");

            migrationBuilder.DropTable(
                name: "DeliveryFees");

            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.DropIndex(
                name: "IX_Carts_DeliveryFeesId",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "DeliveryFeesId",
                table: "Carts");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Articles",
                type: "decimal(10,2)",
                precision: 10,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");
        }
    }
}
