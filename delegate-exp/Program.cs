
using System;
using System.Collections.Generic;

namespace delegate_exp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { exp = 6 ,Name="L"});
            employees.Add(new Employee { exp = 5 ,Name="Man"});
            employees.Add(new Employee { exp = 6 ,Name="Pat"});
            employees.Add(new Employee { exp = 3 ,Name="La"});


            isEligible isEligible = new isEligible(eligibleforPromotion);
            Employee.EligibleForPromotion(employees,isEligible);



            static bool eligibleforPromotion(Employee employee)
            {
                if (employee.exp > 5)
                {
                    return true;
                } 
                else
                {
                    return false;
                }
            }
        }
    }

    delegate  bool isEligible(Employee employee);
    class Employee
    {

        public int salary { get; set; }
        public string Name { get; set; }
        public int exp { get; set; }


        public static void  EligibleForPromotion(List<Employee> employees,isEligible eligible)
        {
            foreach( Employee employee1 in employees)
            {
                if (eligible(employee1))
                {
                    Console.WriteLine($"Name for promotion is {employee1.Name}");
                }
            }
        }
    }
}
