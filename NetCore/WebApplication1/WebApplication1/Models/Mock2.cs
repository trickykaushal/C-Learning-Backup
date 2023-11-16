using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dependency_3.Models
{
    public class Mock2 : IEmployee
    {
        private List<Employee> employee;

        public Mock2(Employee employee)
        {
            this.employee = new List<Employee> {
                new Employee { ID=1,FirstName="Kaushal",LastName="Patel",Address="New Delhi"},
                new Employee { ID=2,FirstName="Kaushal2",LastName="Patel2",Address="New Delhi2"},
                new Employee { ID=3,FirstName="Kaushal3",LastName="Patel3",Address="New Delhi3"}
            };
        }

        public string getEmployee(int id)
        {
            return employee.FirstOrDefault(e => e.ID == id).FirstName;
          
        }
    }
}
