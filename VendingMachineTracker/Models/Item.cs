using System.ComponentModel.DataAnnotations;

namespace VendingMachineTracker.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        public string name { get; set; }

        public ICollection<VendingMachineItem> vendingMachineItems { get; set; }
    }
}
