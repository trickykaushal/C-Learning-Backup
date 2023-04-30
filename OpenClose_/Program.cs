using System;

namespace OpenClose_
{
    class Program 
    {
        static void Main(string[] args)
        {
            var k = new PermEmployeee("Kaushal ", 1234);
            Console.WriteLine("{0:N6}", k.BonusCalc(k.Salary));
            

        }
    }
}
