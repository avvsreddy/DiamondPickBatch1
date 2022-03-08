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
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=DiamondPickDB;Integrated Security=True;MultipleActiveResultSets=True")
                .UseLazyLoadingProxies();


          
            optionsBuilder.LogTo(msg => Console.WriteLine(msg));

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Catagory> Catagories { get; set; }
    }
}
