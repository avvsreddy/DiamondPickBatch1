using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsManagement.ConsoleApp.Entities
{
    public class Product // Entity Class -  Domain Class - POCO class
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
    }
}
