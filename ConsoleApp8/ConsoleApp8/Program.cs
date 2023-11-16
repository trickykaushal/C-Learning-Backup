using System;
using System.Collections.Generic;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Dictionary<string, List<int>> myDictionary = new Dictionary<string, List<int>>();

        }
        public int CalculateFactorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n));
            }

            return Factorial(n);
            // Local function that captures the 'n' variable
            static int Factorial(int number)
            {
                if (number <= 1)
                {
                    return 1;
                }

                return number * Factorial(number - 1);
            }
        }




        public class Node
        {
            public int Value { get; set; }
            public Node Left { get; set; }

            public Node Right { get; set; }

            public static int SumTree(Node root)
            {
                return Sum(root);

                int Sum(Node node)
                {
                    if (node == null)
                    {
                        return 0;
                    }

                    return node.Value + Sum(node.Left) + Sum(node.Right);
                }
            }

        }
    }
}






