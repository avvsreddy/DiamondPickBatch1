using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductsManagement.ConsoleApp.Migrations
{
    public partial class TPH : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductSupplier_Supplier_SuppliersSupplierID",
                table: "ProductSupplier");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Supplier",
                table: "Supplier");

            migrationBuilder.RenameTable(
                name: "Supplier",
                newName: "People");

            migrationBuilder.RenameColumn(
                name: "SuppliersSupplierID",
                table: "ProductSupplier",
                newName: "SuppliersPersonID");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSupplier_SuppliersSupplierID",
                table: "ProductSupplier",
                newName: "IX_ProductSupplier_SuppliersPersonID");

            migrationBuilder.RenameColumn(
                name: "SupplierName",
                table: "People",
                newName: "SupplierType");

            migrationBuilder.RenameColumn(
                name: "SupplierID",
                table: "People",
                newName: "PersonID");

            migrationBuilder.AddColumn<string>(
                name: "CustomerType",
                table: "People",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Discount",
                table: "People",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "People",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "MembershipFee",
                table: "People",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "People",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "People",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_People",
                table: "People",
                column: "PersonID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSupplier_People_SuppliersPersonID",
                table: "ProductSupplier",
                column: "SuppliersPersonID",
                principalTable: "People",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductSupplier_People_SuppliersPersonID",
                table: "ProductSupplier");

            migrationBuilder.DropPrimaryKey(
                name: "PK_People",
                table: "People");

            migrationBuilder.DropColumn(
                name: "CustomerType",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "People");

            migrationBuilder.DropColumn(
                name: "MembershipFee",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "People");

            migrationBuilder.RenameTable(
                name: "People",
                newName: "Supplier");

            migrationBuilder.RenameColumn(
                name: "SuppliersPersonID",
                table: "ProductSupplier",
                newName: "SuppliersSupplierID");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSupplier_SuppliersPersonID",
                table: "ProductSupplier",
                newName: "IX_ProductSupplier_SuppliersSupplierID");

            migrationBuilder.RenameColumn(
                name: "SupplierType",
                table: "Supplier",
                newName: "SupplierName");

            migrationBuilder.RenameColumn(
                name: "PersonID",
                table: "Supplier",
                newName: "SupplierID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Supplier",
                table: "Supplier",
                column: "SupplierID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSupplier_Supplier_SuppliersSupplierID",
                table: "ProductSupplier",
                column: "SuppliersSupplierID",
                principalTable: "Supplier",
                principalColumn: "SupplierID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
