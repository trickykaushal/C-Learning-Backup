using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion
{
     class  employee
    {
        string empName;
        int salary;

        public employee(string empName, int salary)
        {
            EmpName = empName;
            Salary = salary;
        }

        public string EmpName { get => empName; set => empName = value; }
        public int Salary { get => salary; set => salary = value; }


      

        
    }
    interface ICalcBOnus
    {

    }

    

}
