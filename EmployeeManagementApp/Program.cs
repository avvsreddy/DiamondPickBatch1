using EmployeeManagementApp.DataAccess;
using EmployeeManagementApp.Entities;
using System;

namespace EmployeeManagementApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // add new employee
            var e = new Employee {EmpName = "Satish 2", Loc = "Hyb", Salary = 78000 };
            //DiamondPickEmpDb db = new DiamondPickEmpDb();

            EmpRepository repo = new EmpRepository();
            repo.Save(e);
           
            Console.WriteLine("saved");
        }
    }
}
