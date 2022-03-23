using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication3;

namespace WebApplication3.Data
{
    public class WebApplication3Context : DbContext
    {
        public WebApplication3Context (DbContextOptions<WebApplication3Context> options)
            : base(options)
        {
        }

        public DbSet<WebApplication3.Item> Item { get; set; }
    }
}
