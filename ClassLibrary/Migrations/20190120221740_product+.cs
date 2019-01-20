using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassLibrary.Migrations
{
    public partial class product : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Products",
                newName: "TVA");

            migrationBuilder.AddColumn<int>(
                name: "Delivery_time",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "PriceHT",
                table: "Products",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Statut",
                table: "Movements",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Delivery_time",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "PriceHT",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Statut",
                table: "Movements");

            migrationBuilder.RenameColumn(
                name: "TVA",
                table: "Products",
                newName: "Price");
        }
    }
}
