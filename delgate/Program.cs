using System.Text;
using System.Collections;
using System.Collections.Generic;
using System;

namespace delegateTest
{
    class Test
    {
        public static void Main()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { Age = 25, Name = "Me", Salary = 34567890 });
            employees.Add(new Employee { Age = 25, Name = "irsme", Salary = 11568 });
            employees.Add(new Employee { Age = 25, Name = "baca", Salary = 347890 });
            employees.Add(new Employee { Age = 25, Name = "mefgewi ", Salary = 37890 });
            employees.Add(new Employee { Age = 25, Name = "dsfsd", Salary = 34567890 });

            Iseligible iseligible = new Iseligible(isEligibleForPromotion);


            Employee.IsEligibleForPromo(employees, iseligible);




            static bool isEligibleForPromotion(Employee emp)
            {
                if (emp.Salary <15000)
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

    delegate bool Iseligible(Employee emp);


    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }


        public static void IsEligibleForPromo(List<Employee> list, Iseligible iseligible)
        {

            foreach (Employee employee in list)
            {

                if (iseligible(employee))
                {
                    Console.WriteLine($"Employee Promoted Name:{employee.Name}");
                }
            }

        }





    }
}