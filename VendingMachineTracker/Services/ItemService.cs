﻿using VendingMachineTracker.Models;

namespace VendingMachineTracker.Services
{
    public class ItemService
    {
        private VendingMachineTrackerContext context;

        public ItemService(VendingMachineTrackerContext context)
        {
            this.context = context;
        }

        //Getters
        public List<Item> getAllItems() => context.items.ToList();

        public Item getItemById(int id) => context.items.Find(id);

        //Modifiers
        public Item addItem(Item newItem)
        {
            context.items.Add(newItem);
            context.SaveChanges(); 
            
            return newItem;
        }

        public Item modifyItem(Item item)
        {
            Item existingItem = context.items.Find(item.Id);
            existingItem.updateValues(item.name);
            context.SaveChanges();

            return existingItem;
        }

        public void removeItem(int id)
        {
            context.items.Remove(context.items.Find(id));
            context.SaveChanges();
        }

    }
}
