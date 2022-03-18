using KnowledgeHub.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeHub.DataAccess
{
    public class KnowldgeHubDbContext : DbContext
    {


        // used to configure dbcontext in mvc core project
        public KnowldgeHubDbContext(DbContextOptions<KnowldgeHubDbContext> options) : base(options)
        {

        }

        public KnowldgeHubDbContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("");
            }
        }


        public DbSet<Catagory> Catagories { get; set; }
        //public DbSet<Contact> Contacts { get; set; }
        public DbSet<Article> Articles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Catagory>().HasData
            //    (
            //        new Catagory {CatagoryID=111, CatagoryName = "ASP.Net MVC Core", CatagoryDescription="Microsoft ASP.Net MVC Core" },
            //        new Catagory { CatagoryID = 222, CatagoryName = "ASP.Net MVC", CatagoryDescription = "Microsoft ASP.Net MVC" },

            //        new Catagory { CatagoryID = 333, CatagoryName = ".Net Framework", CatagoryDescription = "Microsoft .NEt Framework" },
            //        new Catagory { CatagoryID = 444, CatagoryName = ".Net Core", CatagoryDescription = "Microsoft .Net  Core" }


            //    );
        }
    }
}
