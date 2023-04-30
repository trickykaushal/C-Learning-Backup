using System;

namespace ConsoleApp_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pls enter a number");
            string sRead=Console.ReadLine();
            int Final;
           bool k =int.TryParse(sRead ,out Final);
            if (k)
            {
                Console.WriteLine("YOur inserted value is {0} ", Final);
                if (Final == 10 || Final == 20)
                {
                    Console.WriteLine("Your entered number is 10 or 20");
                }

                else
                {
                    Console.WriteLine("Your Entered Number in niether 10 or nor 20");
                }
            }
            else
            {
                Console.WriteLine("Pls Enter a valid NUmber");
            }
            

           





        }
    }
}

