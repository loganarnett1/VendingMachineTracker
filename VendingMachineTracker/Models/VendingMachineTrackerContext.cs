using Microsoft.EntityFrameworkCore;

namespace VendingMachineTracker.Models
{
    public class VendingMachineTrackerContext : DbContext
    {
        public VendingMachineTrackerContext(DbContextOptions<VendingMachineTrackerContext> options)
            : base(options)
        { }

        public DbSet<Item> items { get; set; }
        public DbSet<VendingMachineItem> vendingMachineItems;
        public DbSet<VendingMachine> vendingMachines { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<VendingMachine>().HasData(
                new VendingMachine { Id = 1, name = "Machine 1", locationDescription = "Near the stairs" }
            );

            modelBuilder.Entity<Item>().HasData(
                new Item { Id = 1, name = "Chips" }
            );

            /*
            modelBuilder.Entity<VendingMachineItem>()
                .HasOne(vmi => vmi.item)
                .WithMany(i => i.vendingMachineItems)
                .HasForeignKey(vmi => vmi.itemId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<VendingMachineItem>()
                .HasOne(vmi => vmi.vendingMachine)
                .WithMany(vm => vm.vendingMachineItems)
                .HasForeignKey(vmi => vmi.vendingMachineId)
                .OnDelete(DeleteBehavior.NoAction);*/
            modelBuilder.Entity<VendingMachineItem>()
                .HasOne(vmi => vmi.vendingMachine)
                .WithMany(vm => vm.vendingMachineItems)
                .HasForeignKey(vm => vm.vendingMachineId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<VendingMachineItem>()
                .HasOne(vmi => vmi.item)
                .WithMany(i => i.vendingMachineItems)
                .HasForeignKey(vm => vm.itemId)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<VendingMachine>()
                .HasMany(vm => vm.vendingMachineItems)
                .WithOne(vmi => vmi.vendingMachine)
                .HasForeignKey(vmi => vmi.vendingMachineId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Item>()
                .HasMany(i => i.vendingMachineItems)
                .WithOne(vmi => vmi.item)
                .HasForeignKey(vmi => vmi.itemId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
