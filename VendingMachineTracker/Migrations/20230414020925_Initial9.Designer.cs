﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VendingMachineTracker.Models;

#nullable disable

namespace VendingMachineTracker.Migrations
{
    [DbContext(typeof(VendingMachineTrackerContext))]
    [Migration("20230414020925_Initial9")]
    partial class Initial9
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("VendingMachineTracker.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("items");
                });

            modelBuilder.Entity("VendingMachineTracker.Models.VendingMachine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("locationDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("vendingMachines");
                });

            modelBuilder.Entity("VendingMachineTracker.Models.VendingMachineItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("itemId")
                        .HasColumnType("int");

                    b.Property<int>("vendingMachineId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("itemId");

                    b.HasIndex("vendingMachineId");

                    b.ToTable("vendingMachineItems");
                });

            modelBuilder.Entity("VendingMachineTracker.Models.VendingMachineItem", b =>
                {
                    b.HasOne("VendingMachineTracker.Models.Item", "item")
                        .WithMany("vendingMachineItems")
                        .HasForeignKey("itemId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("VendingMachineTracker.Models.VendingMachine", "vendingMachine")
                        .WithMany("vendingMachineItems")
                        .HasForeignKey("vendingMachineId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("item");

                    b.Navigation("vendingMachine");
                });

            modelBuilder.Entity("VendingMachineTracker.Models.Item", b =>
                {
                    b.Navigation("vendingMachineItems");
                });

            modelBuilder.Entity("VendingMachineTracker.Models.VendingMachine", b =>
                {
                    b.Navigation("vendingMachineItems");
                });
#pragma warning restore 612, 618
        }
    }
}
