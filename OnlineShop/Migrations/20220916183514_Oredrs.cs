using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineShop.Migrations
{
    public partial class Oredrs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhoneNo",
                schema: "Identity",
                table: "orders",
                newName: "ZipCode");

            migrationBuilder.RenameColumn(
                name: "OrderDate",
                schema: "Identity",
                table: "orders",
                newName: "OrederPlaced");

            migrationBuilder.RenameColumn(
                name: "Name",
                schema: "Identity",
                table: "orders",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "Address",
                schema: "Identity",
                table: "orders",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "Identity",
                table: "orders",
                newName: "OrderId");

            migrationBuilder.AddColumn<string>(
                name: "AddressLine1",
                schema: "Identity",
                table: "orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AddressLine2",
                schema: "Identity",
                table: "orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                schema: "Identity",
                table: "orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                schema: "Identity",
                table: "orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                schema: "Identity",
                table: "orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "OrederTotal",
                schema: "Identity",
                table: "orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressLine1",
                schema: "Identity",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "AddressLine2",
                schema: "Identity",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "Country",
                schema: "Identity",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "FirstName",
                schema: "Identity",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "LastName",
                schema: "Identity",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "OrederTotal",
                schema: "Identity",
                table: "orders");

            migrationBuilder.RenameColumn(
                name: "ZipCode",
                schema: "Identity",
                table: "orders",
                newName: "PhoneNo");

            migrationBuilder.RenameColumn(
                name: "State",
                schema: "Identity",
                table: "orders",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                schema: "Identity",
                table: "orders",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "OrederPlaced",
                schema: "Identity",
                table: "orders",
                newName: "OrderDate");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                schema: "Identity",
                table: "orders",
                newName: "Id");
        }
    }
}
