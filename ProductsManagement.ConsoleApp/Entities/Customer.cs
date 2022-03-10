using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsManagement.ConsoleApp.Entities
{
    public class Customer : Person
    {
        public int Discount { get; set; }
        public string CustomerType { get; set; }

        public int MembershipFee { get; set; }
    }
}
