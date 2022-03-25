using Microsoft.EntityFrameworkCore;
using WorldPopulation.API.Models;

namespace WorldPopulation.API.Data
{
    public class WorldPopulationDbContext : DbContext
    {

        public WorldPopulationDbContext(DbContextOptions<WorldPopulationDbContext> options) : base(options)
        {

        }

        public DbSet<CountryPopulation> CountryPopulations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CountryPopulation>().HasData(
                new CountryPopulation { CountryPopulationID=1, Coutry = "China", Population = 1439323776, YearlyChange = 0.39, NetChange = 5540090, Density = 153, LandArea = 9388211 },
                 new CountryPopulation { CountryPopulationID=2, Coutry = "India", Population = 1380004385, YearlyChange = 0.99, NetChange = 13586631, Density = 464, LandArea = 2973190 }



                ); 
        }

       
        
    }
}
