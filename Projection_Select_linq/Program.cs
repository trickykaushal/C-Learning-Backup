using System;
using System.Linq;
using System.Collections.Generic;
using Projection_Select_linq;

namespace Projection_Select_linq
{
    class Program
    {
        static void Main(string[] args)
        {

            //IEnumerable<string> list = (from employees in Employee.GetEmployees()
            //                            from subject in employees.Subjects
            //                            select subject).Distinct();



            do
            {
                var list = Employee.GetEmployees().Select(x => x);


                Console.WriteLine("Pls Enter Page Number Betwenn 1-4");
                int Pagenumber = 0;
                int pagesize = 3;
                if (int.TryParse(Console.ReadLine(), out Pagenumber))
                {
                    if (Pagenumber > 0 && Pagenumber <= 4)
                    {

                        var k = list.Skip((Pagenumber - 1) * pagesize).Take(pagesize);
                        foreach (var c in k)
                        {
                            Console.WriteLine($"{c.Employee_id} and name is {c.EmpName} ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Pls insert the valid Page Number");

                    }


                }
                else
                {
                    Console.WriteLine("Pls insert the valid Page Number");
                }
            }
            while (true);





        }
    }
}


