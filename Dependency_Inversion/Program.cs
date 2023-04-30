using System;

namespace Dependency_Inversion
{
    class Program
    {
        static void Main(string[] args)
        {
            var kr = new Employee(new Salary());
            kr.Minimumwage = 90;
            kr.Working_hour = 909;
           ;
            Console.WriteLine($"the salary will be {kr.getSalary()}");




        }
    }
}
