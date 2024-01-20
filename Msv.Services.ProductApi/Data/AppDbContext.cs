using Microsoft.EntityFrameworkCore;
using Msv.Services.ProductApi.Models;


namespace Msv.Services.ProductApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Samosa",
                Price = 15,
                Description = "Una descripcion del producto",
                ImageUrl = "https://placehold.co/606x403",
                CategoryName = "Appetizer"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Panner Tikka",
                Price = 25.99,
                Description = "Una descripcion de otro producto",
                ImageUrl = "https://placehold.co/602x402",
                CategoryName = "appetizer"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Sweet Pie",
                Price = 8.50,
                Description = "Una descripcion de otro producto",
                ImageUrl = "https://placehold.co/601x400",
                CategoryName = "Dessert"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Salad",
                Price = 1.20,
                Description = "Descripcion de otro producto mas",
                ImageUrl = "https://placehold.co/600x400",
                CategoryName = "Entree"
            });

        }
    }
}
