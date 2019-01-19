using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassLibrary.Migrations
{
    public partial class movementupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Value",
                table: "Movements",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<Guid>(
                name: "MovementOriginId",
                table: "Movements",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "Movements",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Movements_MovementOriginId",
                table: "Movements",
                column: "MovementOriginId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movements_Users_MovementOriginId",
                table: "Movements",
                column: "MovementOriginId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movements_Users_MovementOriginId",
                table: "Movements");

            migrationBuilder.DropIndex(
                name: "IX_Movements_MovementOriginId",
                table: "Movements");

            migrationBuilder.DropColumn(
                name: "MovementOriginId",
                table: "Movements");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "Movements");

            migrationBuilder.AlterColumn<int>(
                name: "Value",
                table: "Movements",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
