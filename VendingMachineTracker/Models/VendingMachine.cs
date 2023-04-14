using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VendingMachineTracker.Models
{
    public class VendingMachine
    {
        public void updateValues(string name, string locationDescription)
        {
            this.name = name;
            this.locationDescription = locationDescription;
        }

        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string locationDescription { get; set; }
        public ICollection<VendingMachineItem> vendingMachineItems { get; set; } = null!;
    }
}
