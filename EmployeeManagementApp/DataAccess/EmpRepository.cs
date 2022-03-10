using EmployeeManagementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApp.DataAccess
{
    public class EmpRepository : IEmpRepository
    {
        private DiamondPickEmpDb db = new DiamondPickEmpDb();
        public Employee GetEmployee(int id)
        {
            Employee e = db.Employees.Find(id);
            if (e == null)
                throw new Exception("Employee not found");
            return e;
        }

        public List<Employee> GetEmployees()
        {
            return db.Employees.ToList<Employee>();
        }

        public Employee Save(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
            return employee;
        }
    }
}
