using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsManagement.ConsoleApp.Entities
{
    //[Table("Items")]
    public class Product // Entity Class -  Domain Class - POCO class
    {
        //[Key]
        public int ProductID { get; set; }
        [StringLength(50)]
        [Required]
        public string ProductName { get; set; }
        [Column("Cost")]
        public int Price { get; set; }

        public string Brand { get; set; }

        public virtual Catagory Catagory { get; set; }
    }
}
