using Microsoft.EntityFrameworkCore;
using ProductsManagement.ConsoleApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsManagement.ConsoleApp.DataAccess
{
    public class ProductsDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=DiamondPickDBv4;Integrated Security=True;MultipleActiveResultSets=True")
                .UseLazyLoadingProxies();


          
            optionsBuilder.LogTo(msg => Console.WriteLine(msg),Microsoft.Extensions.Logging.LogLevel.Information);

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Catagory> Catagories { get; set; }

        // TPH - TPT
        //public DbSet<Person> People { get; set; } // for TPC dont add abstract class
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

    }
}
