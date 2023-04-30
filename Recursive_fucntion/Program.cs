using System;

namespace Recursive_fucntion
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Number");

            //read number from user    
            int number = Convert.ToInt32(Console.ReadLine());

            //invoke the static method    
            double sum_ofthenum = sum(number);

            //print the factorial result    
            Console.WriteLine("factorial of" + number + "=" + sum_ofthenum.ToString());

        }
          public static int sum(int num)
        {
            if (num == 0)
                return 0;
            
            return num + sum(num - 1);
        } 
    }
}

