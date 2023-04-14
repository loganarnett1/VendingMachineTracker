using Microsoft.EntityFrameworkCore;

namespace VendingMachineTracker.Models
{
    public class VendingMachineTrackerContext : DbContext
    {
        public VendingMachineTrackerContext(DbContextOptions<VendingMachineTrackerContext> options)
            : base(options)
        { }

        public DbSet<Item> items { get; set; }
        public DbSet<VendingMachineItem> vendingMachineItems { get; set; }
        public DbSet<VendingMachine> vendingMachines { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            /*
            modelBuilder.Entity<VendingMachine>().HasData(
                new VendingMachine("Machine 1", "Near the stairs")
            );

            modelBuilder.Entity<Item>().HasData(
                new Item { Id = 1, name = "Chips"},
            );*/

            modelBuilder.Entity<VendingMachineItem>()
                .HasOne(vmi => vmi.vendingMachine)
                .WithMany(vm => vm.vendingMachineItems)
                .HasForeignKey(vmi => vmi.vendingMachineId)
                .HasPrincipalKey(vm => vm.Id)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<VendingMachineItem>()
                .HasOne(vmi => vmi.item)
                .WithMany(i => i.vendingMachineItems)
                .HasForeignKey(vmi => vmi.itemId)
                .HasPrincipalKey(i => i.Id)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<VendingMachine>()
                .HasMany(vm => vm.vendingMachineItems)
                .WithOne(vmi => vmi.vendingMachine)
                .HasForeignKey(vmi => vmi.vendingMachineId)
                .HasPrincipalKey(vm => vm.Id)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Item>()
                .HasMany(i => i.vendingMachineItems)
                .WithOne(vmi => vmi.item)
                .HasForeignKey(vmi => vmi.itemId)
                .HasPrincipalKey(i => i.Id)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
