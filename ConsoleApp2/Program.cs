using System;
using System.Collections.Generic;

namespace Learninng
{
    class Learning2
    {
        public static void Main()
        {
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee() { id = 20, Name = "Kaushal", Experience = 5 });
            emplist.Add(new Employee() { id = 20, Name = "Ranjana", Experience = 4 });
            emplist.Add(new Employee() { id = 20, Name = "Manoj", Experience = 9 });


          

            Employee.promotioncheck(emplist,emp=>emp.Experience>4);

        }
    }
    public delegate bool iseligible(Employee emp);
    public class Employee
    {
        public int id { get; set; }
        public String Name { get; set; }
        public int Experience { get; set; }

        public static void promotioncheck(List<Employee> employees, iseligible PromotionConditon)
        {
            foreach (Employee emp in employees)
            {
                if (PromotionConditon(emp))
                {
                    Console.WriteLine("You are promoted {0}", emp.Name);
                }
            }

        }

    }
}