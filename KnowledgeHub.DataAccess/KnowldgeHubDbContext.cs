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

    }
}
