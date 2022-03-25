using Microsoft.EntityFrameworkCore.Migrations;

namespace WorldPopulation.API.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CountryPopulations",
                columns: table => new
                {
                    CountryPopulationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Coutry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Population = table.Column<long>(type: "bigint", nullable: false),
                    YearlyChange = table.Column<double>(type: "float", nullable: false),
                    NetChange = table.Column<int>(type: "int", nullable: false),
                    Density = table.Column<int>(type: "int", nullable: false),
                    LandArea = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryPopulations", x => x.CountryPopulationID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CountryPopulations");
        }
    }
}
