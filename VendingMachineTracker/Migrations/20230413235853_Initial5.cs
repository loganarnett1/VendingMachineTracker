using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VendingMachineTracker.Migrations
{
    public partial class Initial5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "items",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "vendingMachines",
                keyColumn: "Id",
                keyValue: -1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "items",
                columns: new[] { "Id", "name" },
                values: new object[] { 1, "Chips" });

            migrationBuilder.InsertData(
                table: "vendingMachines",
                columns: new[] { "Id", "locationDescription", "name" },
                values: new object[] { -1, "Near the stairs", "Machine 1" });
        }
    }
}
