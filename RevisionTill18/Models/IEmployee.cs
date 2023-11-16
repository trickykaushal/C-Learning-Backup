using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RevisionTill18.Models
{
    public interface IEmployee
    {
        Employee GetEmployee(int id);
        IEnumerable<Employee> GetAllEmployee();


    }
}
