using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RevisionTill18.Models
{
    public class MockEmployee : IEmployee
    {

        private List<Employee> _employees;

        public MockEmployee()
        {
            _employees = new List<Employee>{
                new Employee() { Department="Development",Id=1,Name="Kaushal" ,Email="Ikaush@gmail.com"},
                new Employee { Department="Development2",Id=2,Name="Raman",Email="Ikaush@gmail.com"},
                new Employee { Department="Development3",Id=3,Name="Me",Email="Ikaush@gmail.com"}
            };
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            var employees = _employees;
            return employees;
        }

        public Employee GetEmployee(int id)
        {
            return _employees.FirstOrDefault(x => x.Id == id);
        }
    }
}
