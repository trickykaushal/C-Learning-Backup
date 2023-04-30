using System;
using System.Linq;

namespace BInarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vs = { 1,5,343425,6,7,8,9,940};
            Array.Sort(vs);
            //foreach (var v in vs)
            //{

            //    console.write(v +"");
            //}

            int key = 8;
            int min = 0;
            int max = vs.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (vs[mid]==key)
                {
                    Console.WriteLine(mid++);
                    break;
                    
                }
                else if (key > vs[mid])
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                    
                }

            }


        }
    }
}
