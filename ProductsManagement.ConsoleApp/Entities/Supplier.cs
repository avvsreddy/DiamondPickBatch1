using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsManagement.ConsoleApp.Entities
{

    [Table("Suppliers")]  // TPT
    public class Supplier : Person
    {
        public int Rating { get; set; }
        public string SupplierType { get; set; }

        public virtual List<Product> Products { get; set; } = new List<Product>();
    }
}
