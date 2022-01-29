using Microsoft.EntityFrameworkCore.Migrations;

namespace Joylet.API.Migrations
{
    public partial class LevelTwoDiscount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DeliveryFees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DeliveryFees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DeliveryFees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "CartDetails",
                table: "Carts",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 5, "ketchup", 999m },
                    { 6, "mayonnaise", 999m },
                    { 7, "fries", 378m },
                    { 8, "ham", 147m }
                });

            migrationBuilder.InsertData(
                table: "CartsItems",
                columns: new[] { "ArticleId", "CartId", "Quantity" },
                values: new object[,]
                {
                    { 5, 3, 1 },
                    { 6, 3, 1 },
                    { 7, 4, 1 },
                    { 8, 5, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CartsItems",
                keyColumns: new[] { "ArticleId", "CartId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "CartsItems",
                keyColumns: new[] { "ArticleId", "CartId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "CartsItems",
                keyColumns: new[] { "ArticleId", "CartId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "CartsItems",
                keyColumns: new[] { "ArticleId", "CartId" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.AlterColumn<string>(
                name: "CartDetails",
                table: "Carts",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

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
                columns: new[] { "Id", "CartDetails"},
                values: new object[,]
                {
                    { 1, "Details 1" },
                    { 2, "Details 2" },
                    { 3, "Details 3" }
                });

            migrationBuilder.InsertData(
                table: "DeliveryFees",
                columns: new[] { "Id", "DeliveryPrice", "IsActive", "IsExpired", "MaxPrice", "MinPrice" },
                values: new object[,]
                {
                    { 1, 800m, true, false, 1000m, 0m },
                    { 2, 400m, true, false, 2000m, 1000m },
                    { 3, 0m, true, false, null, 4000m }
                });
        }
    }
}
