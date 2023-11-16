using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dependency_3.Models
{
    public class EmployeeProp : IEmployee
    {

        private List<Employee> employees;
        public EmployeeProp()
        {
            employees = new List<Employee> { new Employee { ID=1,FirstName="Kaushal",LastName="Patel",Address="New Delhi"},
            new Employee { ID=2,FirstName="Kaushal1",LastName="Patel1",Address="New Delhi1"} };

        }



        public string getEmployee(int id)
        {
            return employees.FirstOrDefault(e => e.ID == id).FirstName;

        }
    }
}
