using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQtoObjectDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Welcome to LINQ to Objects demos");
            // Case 1: Get all names of employees
            var case1 = from e1 in Employee.Employees()
                        select e1.Name;

            // Case 2: Get all names and salary of employees
            var case2 = from e2 in Employee.Employees()
                        select new NameSal{ Name = e2.Name, Salary=e2.Salary };

            // Case 3: Get all names and dept from employees
            var case3 = from e3 in Employee.Employees()
                        select new  { Name = e3.Name, Dept = e3.Dept };

            // Case 4: Get all employees getting salary more than 50k
            var case4 = from e4 in Employee.Employees()
                        where e4.Salary >= 50000
                        select e4;

            // Case 5: Get all Employees total salary

            // Case 6: Get count of employees working in HR dept

            // Case 7: Get the name of the employee who's getting highest salary

            // Case 8: Get the average salary of employees in bangalore

            // Case 9: Get the dept mininum avg salary



            foreach (var item in case1)
            {
                Console.WriteLine(item);
            }
        }
    }

    //class NameDept
    //{
    //    public string Name { get; set; }
    //    public string Dept { get; set; }
    //}

    class NameSal
    {
        public string Name { get; set; }
        public int Salary { get; set; }
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
