using Microsoft.EntityFrameworkCore.Migrations;

namespace WorldPopulation.API.Migrations
{
    public partial class sampledata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CountryPopulations",
                columns: new[] { "CountryPopulationID", "Coutry", "Density", "LandArea", "NetChange", "Population", "YearlyChange" },
                values: new object[] { 1, "China", 153, 9388211, 5540090, 1439323776L, 0.39000000000000001 });

            migrationBuilder.InsertData(
                table: "CountryPopulations",
                columns: new[] { "CountryPopulationID", "Coutry", "Density", "LandArea", "NetChange", "Population", "YearlyChange" },
                values: new object[] { 2, "India", 464, 2973190, 13586631, 1380004385L, 0.98999999999999999 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CountryPopulations",
                keyColumn: "CountryPopulationID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CountryPopulations",
                keyColumn: "CountryPopulationID",
                keyValue: 2);
        }
    }
}
