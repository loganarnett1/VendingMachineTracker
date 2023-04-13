using System.ComponentModel.DataAnnotations;

namespace VendingMachineTracker.Models
{
    public class VendingMachineItem
    {
        [Key]
        public int Id { get; set; }

        public int itemId { get; set; }
        public Item item { get; set; }

        public int vendingMachineId { get; set; }
        public VendingMachine vendingMachine { get; set; }
    }
}
