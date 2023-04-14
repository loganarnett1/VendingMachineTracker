using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VendingMachineTracker.Models
{
    public class Item
    {
        public Item(string name)
        {
            this.name = name;
        }

        public void updateValues(string name)
        {
            this.name = name;
        }

        [Key]
        public int Id { get; set; }

        public string name { get; set; }

        public ICollection<VendingMachineItem> vendingMachineItems { get; set; }
    }
}
