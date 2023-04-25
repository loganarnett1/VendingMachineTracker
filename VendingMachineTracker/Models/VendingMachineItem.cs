using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VendingMachineTracker.Models
{
    public class VendingMachineItem
    {
        public void updateValues(int price)
        {
            this.price = price;
        }

        public string getPriceString()
        {
            string cents = $"{(this.price % 4) * 25}";
            if(cents.Length == 1) { cents = $"0{cents}"; }
            return $"${Math.Floor(this.price / 4.0f)}.{cents}";
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
