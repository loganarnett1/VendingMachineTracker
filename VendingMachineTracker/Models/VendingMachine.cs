using System.ComponentModel.DataAnnotations;

namespace VendingMachineTracker.Models
{
    public class VendingMachine
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string locationDescription { get; set; }
        public ICollection<VendingMachineItem> vendingMachineItems { get; set; }
    }
}
