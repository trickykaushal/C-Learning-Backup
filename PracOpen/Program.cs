using System;

namespace PracOpen
{
    class Program
    {
        static void Main(string[] args)
        {


            var employeeDetailsModified = new employeeManage(new salaryGenerate());
            employeeDetailsModified.Workhour = 8;
            employeeDetailsModified.WorkingSal = 345;
         
    
            Console.WriteLine($"The Total Pay is {employeeDetailsModified.CalcSalary()}");

        }


    }
}
