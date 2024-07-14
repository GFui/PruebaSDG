using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PruebaSDG.Migrations
{
    public partial class PrimerPaso : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CountryModel",
                columns: table => new
                {
                    Country = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Population = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryModel", x => x.Country);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CountryModel");
        }
    }
}
