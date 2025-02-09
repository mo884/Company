using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addComplexTypeAddressInTableBranchAndEmployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Governate",
                table: "Employees",
                newName: "Address_Governate");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "Employees",
                newName: "Address_Country");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Employees",
                newName: "Address_City");

            migrationBuilder.RenameColumn(
                name: "Area",
                table: "Employees",
                newName: "Address_Area");

            migrationBuilder.RenameColumn(
                name: "Address3",
                table: "Employees",
                newName: "Address_Address3");

            migrationBuilder.RenameColumn(
                name: "Address2",
                table: "Employees",
                newName: "Address_Address2");

            migrationBuilder.RenameColumn(
                name: "Address1",
                table: "Employees",
                newName: "Address_Address1");

            migrationBuilder.RenameColumn(
                name: "Governate",
                table: "Branchs",
                newName: "Address_Governate");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "Branchs",
                newName: "Address_Country");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Branchs",
                newName: "Address_City");

            migrationBuilder.RenameColumn(
                name: "Area",
                table: "Branchs",
                newName: "Address_Area");

            migrationBuilder.RenameColumn(
                name: "Address3",
                table: "Branchs",
                newName: "Address_Address3");

            migrationBuilder.RenameColumn(
                name: "Address2",
                table: "Branchs",
                newName: "Address_Address2");

            migrationBuilder.RenameColumn(
                name: "Address1",
                table: "Branchs",
                newName: "Address_Address1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address_Governate",
                table: "Employees",
                newName: "Governate");

            migrationBuilder.RenameColumn(
                name: "Address_Country",
                table: "Employees",
                newName: "Country");

            migrationBuilder.RenameColumn(
                name: "Address_City",
                table: "Employees",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "Address_Area",
                table: "Employees",
                newName: "Area");

            migrationBuilder.RenameColumn(
                name: "Address_Address3",
                table: "Employees",
                newName: "Address3");

            migrationBuilder.RenameColumn(
                name: "Address_Address2",
                table: "Employees",
                newName: "Address2");

            migrationBuilder.RenameColumn(
                name: "Address_Address1",
                table: "Employees",
                newName: "Address1");

            migrationBuilder.RenameColumn(
                name: "Address_Governate",
                table: "Branchs",
                newName: "Governate");

            migrationBuilder.RenameColumn(
                name: "Address_Country",
                table: "Branchs",
                newName: "Country");

            migrationBuilder.RenameColumn(
                name: "Address_City",
                table: "Branchs",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "Address_Area",
                table: "Branchs",
                newName: "Area");

            migrationBuilder.RenameColumn(
                name: "Address_Address3",
                table: "Branchs",
                newName: "Address3");

            migrationBuilder.RenameColumn(
                name: "Address_Address2",
                table: "Branchs",
                newName: "Address2");

            migrationBuilder.RenameColumn(
                name: "Address_Address1",
                table: "Branchs",
                newName: "Address1");
        }
    }
}
