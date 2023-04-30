using System;
using System.Collections.Generic;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {

            Calculator.Sum(567, 343);


           
            List<int> list = new List<int>
            {
                34,
                67,
                54
            };
            Console.WriteLine("The total sum is {0}",(Calculator.Sum(list)));
            
        }
    }
    class Calculator
    {

        [Obsolete]
        public static int Sum(int num1,int num2)
        {
            return num1 + num2;
        }
        public static int Sum(List<int> Numbers)
        {
            int total = 0;

            foreach (int number in Numbers)
            {
                total = total + number;
                
            }
            return total;
           
        }
    }
}
