using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeptEmployeesAPI.Models
{
    // C# representation of the Department table
    public class Department
    {
        public List <Employee> Employees { get; set; }
        public int Id { get; set; }
        public string DeptName { get; set; }
    }
}
