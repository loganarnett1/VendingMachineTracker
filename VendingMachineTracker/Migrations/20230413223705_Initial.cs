using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VendingMachineTracker.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "vendingMachines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    locationDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vendingMachines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VendingMachineItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    itemId = table.Column<int>(type: "int", nullable: false),
                    vendingMachineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendingMachineItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VendingMachineItem_items_itemId",
                        column: x => x.itemId,
                        principalTable: "items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VendingMachineItem_vendingMachines_vendingMachineId",
                        column: x => x.vendingMachineId,
                        principalTable: "vendingMachines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "items",
                columns: new[] { "Id", "name" },
                values: new object[] { 1, "Chips" });

            migrationBuilder.InsertData(
                table: "vendingMachines",
                columns: new[] { "Id", "locationDescription", "name" },
                values: new object[] { 1, "Near the stairs", "Machine 1" });

            migrationBuilder.CreateIndex(
                name: "IX_VendingMachineItem_itemId",
                table: "VendingMachineItem",
                column: "itemId");

            migrationBuilder.CreateIndex(
                name: "IX_VendingMachineItem_vendingMachineId",
                table: "VendingMachineItem",
                column: "vendingMachineId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VendingMachineItem");

            migrationBuilder.DropTable(
                name: "items");

            migrationBuilder.DropTable(
                name: "vendingMachines");
        }
    }
}
