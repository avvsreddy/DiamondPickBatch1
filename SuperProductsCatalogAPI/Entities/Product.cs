namespace SuperProductsCatalogAPI.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Price { get; set; }
        public bool IsInStock { get; set; }

    }
}
