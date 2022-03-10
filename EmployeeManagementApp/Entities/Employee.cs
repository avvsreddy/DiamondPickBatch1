using System;
using System.Collections.Generic;

#nullable disable

namespace EmployeeManagementApp.Entities
{
    public partial class Employee
    {
        
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int? Salary { get; set; }
        public string Loc { get; set; }
    }
}
