using System;
using fsdf;

namespace OutparameterMethod
{
    class Program:program2
    {
        private static int lastValue;
        private static int newValue;

        static void Main(string[] args)
        {
         



            outParamet(out newValue, out lastValue);
            Console.WriteLine($"the new value is {newValue} and last value is {lastValue}");
        }
        public static void outParamet(out int keyValue, out int keynode)
        {

            keyValue = 343;
            keynode = 3434;
            newMethod();
        }

       
    }
}
