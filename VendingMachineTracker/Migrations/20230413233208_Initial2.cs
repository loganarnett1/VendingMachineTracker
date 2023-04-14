using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VendingMachineTracker.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "vendingMachines",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "vendingMachines",
                columns: new[] { "Id", "locationDescription", "name" },
                values: new object[] { -1, "Near the stairs", "Machine 1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "vendingMachines",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.InsertData(
                table: "vendingMachines",
                columns: new[] { "Id", "locationDescription", "name" },
                values: new object[] { 1, "Near the stairs", "Machine 1" });
        }
    }
}
