using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VendingMachineTracker.Migrations
{
    public partial class CascadeDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_vendingMachineItems_items_itemId",
                table: "vendingMachineItems");

            migrationBuilder.AddForeignKey(
                name: "FK_vendingMachineItems_items_itemId",
                table: "vendingMachineItems",
                column: "itemId",
                principalTable: "items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_vendingMachineItems_items_itemId",
                table: "vendingMachineItems");

            migrationBuilder.AddForeignKey(
                name: "FK_vendingMachineItems_items_itemId",
                table: "vendingMachineItems",
                column: "itemId",
                principalTable: "items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
