using Microsoft.EntityFrameworkCore;
using Backend.Models;

namespace Backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Username = "admin",
                    Password = "admin",
                    Role = "User"
                }
            );
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, Name = "CPU Intel i5", PricePerItem = 25000, Quantity = 10, Description = "Intel Core i5 CPU" },
                new Product { ProductId = 2, Name = "CPU AMD Ryzen 5", PricePerItem = 23000, Quantity = 15, Description = "AMD Ryzen 5 CPU" },
                new Product { ProductId = 3, Name = "Motherboard ASUS", PricePerItem = 18000, Quantity = 8, Description = "ASUS Motherboard" },
                new Product { ProductId = 4, Name = "RAM 8GB DDR4", PricePerItem = 8000, Quantity = 20, Description = "8GB DDR4 RAM" },
                new Product { ProductId = 5, Name = "SSD 512GB", PricePerItem = 12000, Quantity = 12, Description = "512GB Solid State Drive" },
                new Product { ProductId = 6, Name = "GPU NVIDIA RTX 3060", PricePerItem = 45000, Quantity = 5, Description = "NVIDIA RTX 3060 Graphics Card" },
                new Product { ProductId = 7, Name = "Power Supply 600W", PricePerItem = 7000, Quantity = 25, Description = "600W PSU" },
                new Product { ProductId = 8, Name = "Cabinet ATX", PricePerItem = 5000, Quantity = 30, Description = "ATX PC Cabinet" },
                new Product { ProductId = 9, Name = "Monitor 24inch", PricePerItem = 15000, Quantity = 10, Description = "24-inch Monitor" },
                new Product { ProductId = 10, Name = "Keyboard Mechanical", PricePerItem = 3500, Quantity = 18, Description = "Mechanical Keyboard" }
            );


        }
    }
}
