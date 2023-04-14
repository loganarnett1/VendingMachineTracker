using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VendingMachineTracker.Migrations
{
    public partial class Initial7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VendingMachineItem_items_itemId",
                table: "VendingMachineItem");

            migrationBuilder.DropForeignKey(
                name: "FK_VendingMachineItem_vendingMachines_vendingMachineId",
                table: "VendingMachineItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VendingMachineItem",
                table: "VendingMachineItem");

            migrationBuilder.RenameTable(
                name: "VendingMachineItem",
                newName: "vendingMachineItems");

            migrationBuilder.RenameIndex(
                name: "IX_VendingMachineItem_vendingMachineId",
                table: "vendingMachineItems",
                newName: "IX_vendingMachineItems_vendingMachineId");

            migrationBuilder.RenameIndex(
                name: "IX_VendingMachineItem_itemId",
                table: "vendingMachineItems",
                newName: "IX_vendingMachineItems_itemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_vendingMachineItems",
                table: "vendingMachineItems",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_vendingMachineItems_items_itemId",
                table: "vendingMachineItems",
                column: "itemId",
                principalTable: "items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_vendingMachineItems_vendingMachines_vendingMachineId",
                table: "vendingMachineItems",
                column: "vendingMachineId",
                principalTable: "vendingMachines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_vendingMachineItems_items_itemId",
                table: "vendingMachineItems");

            migrationBuilder.DropForeignKey(
                name: "FK_vendingMachineItems_vendingMachines_vendingMachineId",
                table: "vendingMachineItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_vendingMachineItems",
                table: "vendingMachineItems");

            migrationBuilder.RenameTable(
                name: "vendingMachineItems",
                newName: "VendingMachineItem");

            migrationBuilder.RenameIndex(
                name: "IX_vendingMachineItems_vendingMachineId",
                table: "VendingMachineItem",
                newName: "IX_VendingMachineItem_vendingMachineId");

            migrationBuilder.RenameIndex(
                name: "IX_vendingMachineItems_itemId",
                table: "VendingMachineItem",
                newName: "IX_VendingMachineItem_itemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VendingMachineItem",
                table: "VendingMachineItem",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VendingMachineItem_items_itemId",
                table: "VendingMachineItem",
                column: "itemId",
                principalTable: "items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VendingMachineItem_vendingMachines_vendingMachineId",
                table: "VendingMachineItem",
                column: "vendingMachineId",
                principalTable: "vendingMachines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
