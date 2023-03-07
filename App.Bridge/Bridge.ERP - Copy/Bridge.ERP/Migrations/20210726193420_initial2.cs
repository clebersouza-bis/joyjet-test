using Microsoft.EntityFrameworkCore.Migrations;

namespace Bridge.ERP.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddForeignKey(
                name: "FK_Phones_Properties_PropertyId",
                table: "Phones",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Phones_Properties_PropertyId",
                table: "Phones");

            migrationBuilder.DropIndex(
                name: "IX_Phones_PropertyId",
                table: "Phones");
        }
    }
}
