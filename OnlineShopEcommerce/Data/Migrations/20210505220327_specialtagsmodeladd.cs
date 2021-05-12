using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;


namespace OnlineShopEcommerce.Data.Migrations
{
    public partial class specialtagsmodeladd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_SpecialTag_SpecialTagId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SpecialTag",
                table: "SpecialTag");

            migrationBuilder.RenameTable(
                name: "SpecialTag",
                newName: "SpecialTags");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SpecialTags",
                table: "SpecialTags",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_SpecialTags_SpecialTagId",
                table: "Products",
                column: "SpecialTagId",
                principalTable: "SpecialTags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_SpecialTags_SpecialTagId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SpecialTags",
                table: "SpecialTags");

            migrationBuilder.RenameTable(
                name: "SpecialTags",
                newName: "SpecialTag");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SpecialTag",
                table: "SpecialTag",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_SpecialTag_SpecialTagId",
                table: "Products",
                column: "SpecialTagId",
                principalTable: "SpecialTag",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
