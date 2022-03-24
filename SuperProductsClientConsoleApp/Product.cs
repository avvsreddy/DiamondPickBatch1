using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperProductsClientConsoleApp
{
    public class Product
    {
        public int productID { get; set; }
        public string name { get; set; }
        public string brand { get; set; }
        public int price { get; set; }
        public bool isInStock { get; set; }
    }
}
