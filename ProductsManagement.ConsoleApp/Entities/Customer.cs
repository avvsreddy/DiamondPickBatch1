using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsManagement.ConsoleApp.Entities
{
    [Table("Customers")] // TPT
    public class Customer : Person
    {
        public int Discount { get; set; }
        public string CustomerType { get; set; }

        public int MembershipFee { get; set; }
    }
}
