using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassLibrary.Migrations
{
    public partial class update0801 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Product_Name",
                table: "Movements");

            migrationBuilder.DropColumn(
                name: "Product_Name",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "User_id",
                table: "Baskets");

            migrationBuilder.RenameColumn(
                name: "isSeller",
                table: "Users",
                newName: "IsSeller");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Products",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Movements",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Inventories",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Baskets",
                newName: "Id");

            migrationBuilder.AddColumn<Guid>(
                name: "ProductMovedId",
                table: "Movements",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ProductStockId",
                table: "Inventories",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BasketOwnerId",
                table: "Baskets",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movements_ProductMovedId",
                table: "Movements",
                column: "ProductMovedId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_ProductStockId",
                table: "Inventories",
                column: "ProductStockId");

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_BasketOwnerId",
                table: "Baskets",
                column: "BasketOwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Baskets_Users_BasketOwnerId",
                table: "Baskets",
                column: "BasketOwnerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_Products_ProductStockId",
                table: "Inventories",
                column: "ProductStockId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Movements_Products_ProductMovedId",
                table: "Movements",
                column: "ProductMovedId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Baskets_Users_BasketOwnerId",
                table: "Baskets");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_Products_ProductStockId",
                table: "Inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_Movements_Products_ProductMovedId",
                table: "Movements");

            migrationBuilder.DropIndex(
                name: "IX_Movements_ProductMovedId",
                table: "Movements");

            migrationBuilder.DropIndex(
                name: "IX_Inventories_ProductStockId",
                table: "Inventories");

            migrationBuilder.DropIndex(
                name: "IX_Baskets_BasketOwnerId",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "ProductMovedId",
                table: "Movements");

            migrationBuilder.DropColumn(
                name: "ProductStockId",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "BasketOwnerId",
                table: "Baskets");

            migrationBuilder.RenameColumn(
                name: "IsSeller",
                table: "Users",
                newName: "isSeller");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Products",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Movements",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Inventories",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Baskets",
                newName: "id");

            migrationBuilder.AddColumn<Guid>(
                name: "Product_Name",
                table: "Movements",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Product_Name",
                table: "Inventories",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "User_id",
                table: "Baskets",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
