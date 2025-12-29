using Microsoft.EntityFrameworkCore;
using MVC_Database_Integration__Shoppers_.Models;

namespace MVC_Database_Integration__Shoppers_.Data
{
    public class ShoppersDbContext : DbContext
    {
        public ShoppersDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> products { get; set; } 
        public DbSet<Summary> summary { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<ProductImage> productImages { get; set; }
    }
}
