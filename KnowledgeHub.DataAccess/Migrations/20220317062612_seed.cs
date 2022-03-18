using Microsoft.EntityFrameworkCore.Migrations;

namespace KnowledgeHub.DataAccess.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Catagories",
                columns: new[] { "CatagoryID", "CatagoryDescription", "CatagoryName" },
                values: new object[,]
                {
                    { 111, "Microsoft ASP.Net MVC Core", "ASP.Net MVC Core" },
                    { 222, "Microsoft ASP.Net MVC", "ASP.Net MVC" },
                    { 333, "Microsoft .NEt Framework", ".Net Framework" },
                    { 444, "Microsoft .Net  Core", ".Net Core" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Catagories",
                keyColumn: "CatagoryID",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Catagories",
                keyColumn: "CatagoryID",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Catagories",
                keyColumn: "CatagoryID",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Catagories",
                keyColumn: "CatagoryID",
                keyValue: 444);
        }
    }
}
