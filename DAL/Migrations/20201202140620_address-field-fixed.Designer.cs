﻿// <auto-generated />
using DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(StoreDbContext))]
    [Migration("20201202140620_address-field-fixed")]
    partial class addressfieldfixed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DAL.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("Pricture")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new { Id = 1, Manufacturer = "Gibson", Name = "Guitar", Pricture = "picture_link" },
                        new { Id = 2, Manufacturer = "Yamaha", Name = "Piano", Pricture = "picture_link" },
                        new { Id = 3, Manufacturer = "Dadario", Name = "Strings", Pricture = "picture_link" }
                    );
                });

            modelBuilder.Entity("DAL.Entities.Store", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("Stores");

                    b.HasData(
                        new { Id = 1, Address = "New York, #132", Name = "MusicRoom", Type = "Market" },
                        new { Id = 2, Address = "Las Vegas, #9", Name = "MusicHouse", Type = "Market" }
                    );
                });

            modelBuilder.Entity("DAL.Entities.StoreProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BarCode");

                    b.Property<int>("Price");

                    b.Property<int>("ProductID");

                    b.Property<int>("StoreID");

                    b.HasKey("Id");

                    b.HasIndex("ProductID");

                    b.HasIndex("StoreID");

                    b.ToTable("StoreProduct");

                    b.HasData(
                        new { Id = 1, BarCode = 12216654, Price = 980, ProductID = 1, StoreID = 1 },
                        new { Id = 2, BarCode = 12315651, Price = 1080, ProductID = 1, StoreID = 2 },
                        new { Id = 3, BarCode = 12451210, Price = 1900, ProductID = 2, StoreID = 2 }
                    );
                });

            modelBuilder.Entity("DAL.Entities.StoreProduct", b =>
                {
                    b.HasOne("DAL.Entities.Product", "Product")
                        .WithMany("ProductStores")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Entities.Store", "Store")
                        .WithMany("StoreProducts")
                        .HasForeignKey("StoreID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
