﻿// <auto-generated />
using System;
using BankAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BankAPI.Migrations
{
    [DbContext(typeof(BankAPIDBContext))]
    partial class BankAPIDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BankAPI.Model.Address", b =>
                {
                    b.Property<int>("AddressID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressID"), 1L, 1);

                    b.Property<string>("AddressDetail")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("AddressName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.HasKey("AddressID");

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            AddressID = 1,
                            AddressDetail = "Menekşe Mah. Petek Sk. No:31 Kat:3 Daire:5",
                            AddressName = "Home",
                            CustomerID = 1
                        },
                        new
                        {
                            AddressID = 3,
                            AddressDetail = "Eskiler Cad. Fırın Sk. No:38 Pendik",
                            AddressName = "Work",
                            CustomerID = 2
                        },
                        new
                        {
                            AddressID = 4,
                            AddressDetail = "Yedi İklim Mah. Güngören Cad. Lacivert Sk. No:45 Kat:3 Daire:7",
                            AddressName = "Work2",
                            CustomerID = 3
                        },
                        new
                        {
                            AddressID = 5,
                            AddressDetail = "Çakmak Cad. Turgut Özal Sk. No:16 Kat:1 Daire:13",
                            AddressName = "MomHome",
                            CustomerID = 4
                        });
                });

            modelBuilder.Entity("BankAPI.Model.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerID"), 1L, 1);

                    b.Property<int>("AddressID")
                        .HasColumnType("int");

                    b.Property<int?>("AddressID1")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("CustomerID");

                    b.HasIndex("AddressID1");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerID = 1,
                            AddressID = 1,
                            Name = "Ahmet"
                        },
                        new
                        {
                            CustomerID = 2,
                            AddressID = 3,
                            Name = "Veli"
                        },
                        new
                        {
                            CustomerID = 3,
                            AddressID = 4,
                            Name = "Efe"
                        },
                        new
                        {
                            CustomerID = 4,
                            AddressID = 5,
                            Name = "Orhan"
                        });
                });

            modelBuilder.Entity("BankAPI.Model.CustomerOrder", b =>
                {
                    b.Property<int>("CustomerOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerOrderId"), 1L, 1);

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("CustomerOrderId");

                    b.HasIndex("CustomerID");

                    b.HasIndex("ProductID");

                    b.ToTable("CustumerOrders");

                    b.HasData(
                        new
                        {
                            CustomerOrderId = 1,
                            CustomerID = 1,
                            ProductID = 1,
                            Quantity = 3
                        },
                        new
                        {
                            CustomerOrderId = 2,
                            CustomerID = 3,
                            ProductID = 4,
                            Quantity = 5
                        },
                        new
                        {
                            CustomerOrderId = 3,
                            CustomerID = 4,
                            ProductID = 4,
                            Quantity = 2
                        },
                        new
                        {
                            CustomerOrderId = 4,
                            CustomerID = 1,
                            ProductID = 3,
                            Quantity = 7
                        });
                });

            modelBuilder.Entity("BankAPI.Model.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductID"), 1L, 1);

                    b.Property<string>("Barcode")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(85)
                        .HasColumnType("nvarchar(85)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("ProductID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductID = 1,
                            Barcode = "11122233344",
                            Description = "Toy",
                            Price = 33,
                            ProductName = "teddy bear"
                        },
                        new
                        {
                            ProductID = 2,
                            Barcode = "21295395534",
                            Description = "Home equipment",
                            Price = 26,
                            ProductName = "lamp"
                        },
                        new
                        {
                            ProductID = 3,
                            Barcode = "21278000004",
                            Description = "Garden equipment",
                            Price = 13,
                            ProductName = "fork"
                        },
                        new
                        {
                            ProductID = 4,
                            Barcode = "53501612766",
                            Description = "Bathroom equipment",
                            Price = 15,
                            ProductName = "toilet paper"
                        });
                });

            modelBuilder.Entity("BankAPI.Model.Customer", b =>
                {
                    b.HasOne("BankAPI.Model.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressID1");

                    b.Navigation("Address");
                });

            modelBuilder.Entity("BankAPI.Model.CustomerOrder", b =>
                {
                    b.HasOne("BankAPI.Model.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BankAPI.Model.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");
                });
#pragma warning restore 612, 618
        }
    }
}
