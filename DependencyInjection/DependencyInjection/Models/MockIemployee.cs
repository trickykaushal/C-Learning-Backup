using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Models
{
    public class MockIemployee : IEmployee
    {
        private List<Employee> _employeeList;

        public MockIemployee()
        {
            _employeeList = new List<Employee>
            {
                new Employee{Id=1,Name="Kaushal",Department="IT",Email="K@gmail.com"},
                new Employee{Id=2,Name="Kaushal1",Department="IT1",Email="K1@gmail.com"},
                new Employee{Id=3,Name="Kaushal2",Department="IT2",Email="K2@gmail.com"},
                new Employee{Id=4,Name="Kaushal3",Department="IT3",Email="K3@gmail.com"}
            };
        }


        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == id);

        }



    }
}
