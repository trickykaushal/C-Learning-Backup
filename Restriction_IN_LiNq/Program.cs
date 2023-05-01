using System;
using System.Collections.Generic;
using System.Linq;


namespace Restriction_IN_LiNq
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] IntList = { 1, 24, 5, 6, 6, 77, 7 };
            Func<int, bool> predicate = x => x > 24;
            var SmallestNum=IntList.Min(x => x);
            int? result = null;
            foreach(var sn in IntList)
            {
                if (sn % 2 == 0)
                {
                    if (!result.HasValue || sn < result)
                    {
                        result = sn;
                    }

                }
                
                
            }
            Console.WriteLine(result);


            var k = IntList.Where(num => getEven(num));

            var k2 = IntList.Select((a, b) => new
            {
                Number = a,
                Index = b
            });



            foreach (var k1 in k)
            {
                Console.WriteLine(k1);
                //Console.WriteLine(k1.Number);
            }


        }

        private static bool getEven(int num)
        {
            return num % 2 == 0;
        }

        private static int fileCheck(int num)
        {

            return num;


        }
    }
}
