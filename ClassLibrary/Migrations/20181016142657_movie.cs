using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassLibrary.Migrations
{
    public partial class movie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "Directorid",
                table: "Movies",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Movieid = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.id);
                    table.ForeignKey(
                        name: "FK_Comment_Movies_Movieid",
                        column: x => x.Movieid,
                        principalTable: "Movies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Firstname = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MovieActor",
                columns: table => new
                {
                    ActorId = table.Column<Guid>(nullable: false),
                    MovieId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieActor", x => new { x.ActorId, x.MovieId });
                    table.ForeignKey(
                        name: "FK_MovieActor_Person_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Person",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieActor_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_Directorid",
                table: "Movies",
                column: "Directorid");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_Movieid",
                table: "Comment",
                column: "Movieid");

            migrationBuilder.CreateIndex(
                name: "IX_MovieActor_MovieId",
                table: "MovieActor",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Person_Directorid",
                table: "Movies",
                column: "Directorid",
                principalTable: "Person",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Person_Directorid",
                table: "Movies");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "MovieActor");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Movies_Directorid",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Directorid",
                table: "Movies");
        }
    }
}
