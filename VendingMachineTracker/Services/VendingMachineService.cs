using Microsoft.EntityFrameworkCore;
using VendingMachineTracker.Models;

namespace VendingMachineTracker.Services
{
    public class VendingMachineService
    {
        private VendingMachineTrackerContext context;

        public VendingMachineService(VendingMachineTrackerContext context)
        {
            this.context = context;
        }

        //Getters
        public List<VendingMachine> getVendingMachines() => context.vendingMachines.ToList();

        public VendingMachine getVendingMachineById(int id) => context.vendingMachines
            .Include(vm => vm.vendingMachineItems)
            .ThenInclude(vmi => vmi.item)
            .FirstOrDefault(vm => vm.Id == id);

        public List<VendingMachineItem> getVendingMachineItems(int vendingMachineId)
        {
            return context.vendingMachines.Find(vendingMachineId).vendingMachineItems.ToList();
        }

        //Modifiers
        public VendingMachine addVendingMachine(VendingMachine newVendingMachine)
        {
            context.vendingMachines.Add(newVendingMachine);
            context.SaveChanges();

            return newVendingMachine;
        }

        public VendingMachineItem addVendingMachineItem(VendingMachineItem newVendingMachineItem)
        {
            context.vendingMachineItems.Add(newVendingMachineItem);
            context.SaveChanges();

            return newVendingMachineItem;
        }

        public VendingMachine modifyVendingMachine(VendingMachine vendingMachine)
        {
            VendingMachine existingVendingMachine = context.vendingMachines.Find(vendingMachine.Id);
            existingVendingMachine.updateValues(vendingMachine.name, vendingMachine.locationDescription);
            context.SaveChanges();

            return existingVendingMachine;
        }

        public VendingMachineItem modifyVendingMachineItem(VendingMachineItem vendingMachineItem)
        {
            VendingMachineItem existingVendingMachineItem = context.vendingMachineItems.Find(vendingMachineItem.Id);
            existingVendingMachineItem.updateValues(vendingMachineItem.price);
            context.SaveChanges();

            return existingVendingMachineItem;
        }

        public List<VendingMachineItem> setVendingMachineItems(List<VendingMachineItem> items, int vendingMachineId)
        {
            context.vendingMachineItems.RemoveRange(getVendingMachineItems(vendingMachineId));
            context.vendingMachineItems.AddRange(items);
            context.SaveChanges();

            return items;
        }

        public void removeVendingMachine(int id)
        {
            context.vendingMachines.Remove(context.vendingMachines.Find(id));
            context.SaveChanges();
        }

        public void removeVendingMachineItem(int id)
        {
            context.vendingMachineItems.Remove(context.vendingMachineItems.Find(id));
            context.SaveChanges();
        }


    }
}
