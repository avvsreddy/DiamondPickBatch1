using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsManagement.ConsoleApp.Entities
{
    abstract public class Person
    {
        public int PersonID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Contact { get; set; }
    }
}
