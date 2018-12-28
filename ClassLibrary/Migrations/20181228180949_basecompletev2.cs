using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassLibrary.Migrations
{
    public partial class basecompletev2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Baskets",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    User_id = table.Column<Guid>(nullable: false),
                    Product_name = table.Column<string>(nullable: true),
                    Number = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baskets", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    Product_Name = table.Column<Guid>(nullable: false),
                    Stock = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Movements",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    Product_Name = table.Column<Guid>(nullable: false),
                    Type_of_movement = table.Column<string>(nullable: true),
                    Value = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movements", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Picture = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    Stock_place = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Baskets");

            migrationBuilder.DropTable(
                name: "Inventories");

            migrationBuilder.DropTable(
                name: "Movements");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
