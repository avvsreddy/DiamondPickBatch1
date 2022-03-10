using EmployeeManagementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EmployeeManagementApp.DataAccess
{
    public interface IEmpRepository
    {
        Employee Save(Employee employee);
        List<Employee> GetEmployees();
        Employee GetEmployee(int id);

    }
}
