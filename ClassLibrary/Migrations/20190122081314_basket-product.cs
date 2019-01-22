using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassLibrary.Migrations
{
    public partial class basketproduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Product_name",
                table: "Baskets");

            migrationBuilder.AddColumn<Guid>(
                name: "Product_chooseId",
                table: "Baskets",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_Product_chooseId",
                table: "Baskets",
                column: "Product_chooseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Baskets_Products_Product_chooseId",
                table: "Baskets",
                column: "Product_chooseId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Baskets_Products_Product_chooseId",
                table: "Baskets");

            migrationBuilder.DropIndex(
                name: "IX_Baskets_Product_chooseId",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "Product_chooseId",
                table: "Baskets");

            migrationBuilder.AddColumn<string>(
                name: "Product_name",
                table: "Baskets",
                nullable: true);
        }
    }
}
