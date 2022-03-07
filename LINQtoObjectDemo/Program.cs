using System;
using System.Collections.Generic;

namespace LINQtoObjectDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }
        public string Loc { get; set; }
        public int Salary { get; set; }

        public static List<Employee> Employees()
        {
            return new List<Employee>
            {
                new Employee {ID=111, Name = "Suresh", Dept = "HR", Loc = "Bangalore", Salary = 75000  },
                new Employee {ID=222, Name = "Girish", Dept = "HR", Loc = "Bangalore", Salary = 76000  },
                new Employee {ID=345, Name = "Mahesh", Dept = "IT", Loc = "Chennai", Salary = 55000  },
                new Employee {ID=567, Name = "Somesh", Dept = "ACC", Loc = "Bangalore", Salary = 75000  },
                new Employee {ID=121, Name = "Ramesh", Dept = "HR", Loc = "Delhi", Salary = 70000  },
                new Employee {ID=634, Name = "Satish", Dept = "IT", Loc = "Hyderabad", Salary = 35000  },
                new Employee {ID=288, Name = "Pranesh", Dept = "HR", Loc = "Pune", Salary = 45000  },
                new Employee {ID=845, Name = "Yatish", Dept = "DevOps", Loc = "Bangalore", Salary = 25000  },
                new Employee {ID=980, Name = "Kumaresh", Dept = "Development", Loc = "Bangalore", Salary = 75000  },
            };
        }
    }
}
