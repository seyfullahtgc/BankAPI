using BankAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace BankAPI.Data
{
    public class BankAPIDBContext : DbContext
    {
        public BankAPIDBContext(DbContextOptions<BankAPIDBContext> options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<CustomerOrder> CustumerOrders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Address>().HasData(
                                   new Address { AddressID = 1, CustomerID = 1, AddressName = "Home", AddressDetail = "Menekşe Mah. Petek Sk. No:31 Kat:3 Daire:5" },
                                   new Address { AddressID = 3, CustomerID = 2, AddressName = "Work", AddressDetail = "Eskiler Cad. Fırın Sk. No:38 Pendik" },
                                   new Address { AddressID = 4, CustomerID = 3, AddressName = "Work2", AddressDetail = "Yedi İklim Mah. Güngören Cad. Lacivert Sk. No:45 Kat:3 Daire:7" },
                                   new Address { AddressID = 5, CustomerID = 4, AddressName = "MomHome", AddressDetail = "Çakmak Cad. Turgut Özal Sk. No:16 Kat:1 Daire:13" }

                                  );

            modelBuilder.Entity<Product>().HasData(
                                              new Product { ProductID = 1, Barcode = "11122233344", Description = "Toy", Price = 33, ProductName = "teddy bear" },
                                              new Product { ProductID = 2, Barcode = "21295395534", Description = "Home equipment", Price = 26, ProductName = "lamp" },
                                              new Product { ProductID = 3, Barcode = "21278000004", Description = "Garden equipment", Price = 13, ProductName = "fork" },
                                              new Product { ProductID = 4, Barcode = "53501612766", Description = "Bathroom equipment", Price = 15, ProductName = "toilet paper" }
                                             );

            modelBuilder.Entity<Customer>().HasData(
                    new Customer { CustomerID = 1, Name = "Ahmet", AddressID = 1 },
                    new Customer { CustomerID = 2, Name = "Veli", AddressID = 3 },
                    new Customer { CustomerID = 3, Name = "Efe", AddressID = 4 },
                    new Customer { CustomerID = 4, Name = "Orhan", AddressID = 5 }
                );

            modelBuilder.Entity<CustomerOrder>().HasData(
                   new CustomerOrder { CustomerOrderId = 1, CustomerID = 1, ProductID = 1, Quantity = 3, },
                    new CustomerOrder { CustomerOrderId = 2, CustomerID = 3, ProductID = 4, Quantity = 5 },
                     new CustomerOrder { CustomerOrderId = 3, CustomerID = 4, ProductID = 4, Quantity = 2 },
                      new CustomerOrder { CustomerOrderId = 4, CustomerID = 1, ProductID = 3, Quantity = 7 }

               );

        }


    }
}
