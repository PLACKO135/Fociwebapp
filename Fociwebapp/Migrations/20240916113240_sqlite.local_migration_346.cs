using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fociwebapp.Migrations
{
    /// <inheritdoc />
    public partial class sqlitelocal_migration_346 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Meccsek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fordulo = table.Column<int>(type: "INTEGER", nullable: false),
                    HazaiVeg = table.Column<int>(type: "INTEGER", nullable: false),
                    VendegVeg = table.Column<int>(type: "INTEGER", nullable: false),
                    HazaiFel = table.Column<int>(type: "INTEGER", nullable: false),
                    VendegFel = table.Column<int>(type: "INTEGER", nullable: false),
                    VendegNev = table.Column<string>(type: "TEXT", nullable: true),
                    HazaiNev = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meccsek", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meccsek");
        }
    }
}
