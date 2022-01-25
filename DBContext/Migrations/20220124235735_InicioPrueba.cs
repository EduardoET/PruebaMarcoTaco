using Microsoft.EntityFrameworkCore.Migrations;

namespace ModeloDB.Migrations
{
    public partial class InicioPrueba : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "languages",
                columns: table => new
                {
                    languageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    last_update = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_languages", x => x.languageId);
                });

            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    filmId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    release_year = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    language_Id = table.Column<int>(type: "int", nullable: false),
                    rental_duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rental_rate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    length = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    replacement_cost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rating = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    last_update = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    special_features = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fulltext = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    languageId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.filmId);
                    table.ForeignKey(
                        name: "FK_Films_languages_languageId",
                        column: x => x.languageId,
                        principalTable: "languages",
                        principalColumn: "languageId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    inventoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    film_Id = table.Column<int>(type: "int", nullable: false),
                    store_Id = table.Column<int>(type: "int", nullable: false),
                    last_update = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    filmId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.inventoryId);
                    table.ForeignKey(
                        name: "FK_Inventories_Films_filmId",
                        column: x => x.filmId,
                        principalTable: "Films",
                        principalColumn: "filmId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Films_languageId",
                table: "Films",
                column: "languageId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_filmId",
                table: "Inventories",
                column: "filmId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inventories");

            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropTable(
                name: "languages");
        }
    }
}
