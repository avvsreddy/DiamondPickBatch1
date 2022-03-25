namespace WorldPopulation.API.Models
{
    public class CountryPopulation
    {
        public int CountryPopulationID { get; set; }

        // add properties as per https://www.worldometers.info/world-population/
        public string Coutry { get; set; }
        public long Population { get; set; }
        public double YearlyChange { get; set; }
        public int NetChange { get; set; }
        public int Density { get; set; }
        public int LandArea { get; set; }


    }
}
