using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WorldPopulation.API.Data;
using WorldPopulation.API.Models;
using System.Linq;
using System.Collections.Generic;

namespace WorldPopulation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorldPopulationController : ControllerBase
    {
        private readonly WorldPopulationDbContext db;

        public WorldPopulationController(WorldPopulationDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public List<CountryPopulation> GetPopulation()
        {
            return db.CountryPopulations.ToList();
        }

        [HttpGet]
        [Route("{country}")]
        public List<CountryPopulation> GetPopulation(string country)
        {
            return db.CountryPopulations.Where(c => c.Coutry == country).ToList();
        }

    }
}
