using Microsoft.EntityFrameworkCore;
using SuperProductsCatalogAPI.Entities;

namespace SuperProductsCatalogAPI.Data
{
    public class ProductsDbContext : DbContext
    {
        public ProductsDbContext(DbContextOptions<ProductsDbContext> options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
    }
}
