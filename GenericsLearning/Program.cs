using System;

namespace GenericsLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            bool compareValue=Number<String>.Compare("Kaushal","Kaushal");
            if (compareValue)
            {
                Console.WriteLine("The given Values Are Equal");
            }
            else
            {
                Console.WriteLine("The given values are not equal");
            }
            
        }
    }
    public class Number<T>
    {
        public static bool Compare(T value1,T value2)
        {
            return value1.Equals(value2);
        }
    }
}
