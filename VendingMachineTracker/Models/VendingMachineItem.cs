using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VendingMachineTracker.Models
{
    public class VendingMachineItem
    {
        public VendingMachineItem(int itemId, int vendingMachineId)
        {
            this.itemId = itemId;
            this.vendingMachineId = vendingMachineId;
        }

        public void updateValues(int price)
        {
            this.price = price;
        }


        [Key]
        public int Id { get; set; }

        public int price { get; set; } //Amount of quarters

        public int itemId { get; set; }
        public Item item { get; set; } = null!;

        public int vendingMachineId { get; set; }
        public VendingMachine vendingMachine { get; set; } = null!;
    }
}
