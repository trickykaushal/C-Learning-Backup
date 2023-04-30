using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {

        public static void Main()
        {
            foreach (var item in Func(5, 10))
            {
                Console.WriteLine(item);

            }

            static IEnumerable<int> Func(int start, int number)
            {
                for (int i = 0; i < number; i++)
                {

                    yield return start + start * i;
                }


            }


        }


    }

}
