using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClose_
{
    public abstract class Employee
    {
        private string empName;
        private decimal salary;

        public Employee(string empName, decimal salary)
        {
            EmpName = empName;
            Salary = salary;
        }


        public string EmpName { get => empName; set => empName = value; }
        public decimal  Salary { get => salary; set => salary = value; }

        public abstract decimal BonusCalc(decimal salary);


    }
    class PermEmployeee : Employee
    {
        public PermEmployeee(string empName, decimal salary) : base(empName, salary)
        {
        }

        public override decimal BonusCalc(decimal salary)
        {
            return salary * 0.1m;
        }
    }

    class ContractEmp : Employee
    {
        public ContractEmp(string empName, decimal salary) : base(empName, salary)
        {
        }

        public override decimal BonusCalc(decimal salary)
        {
            return salary * 0.05m;
        }
    }
}
