using System;

namespace Generics_Learning
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int num1 = 67;
            int num2 = 68;


           bool result= Compare.IsEqual<int>(num1,num2);

            if (result)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
         

        }



    }


    public class Compare
    {
        public static bool IsEqual<T>(T value1,T value2)
        {
            return value2.Equals(value1);
        }
    }
}
