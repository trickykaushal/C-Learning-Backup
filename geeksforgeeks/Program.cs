using System;
using System.Collections.Generic;

namespace geeksforgeeks
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 12;
            int number = 5;
            int[] ar = { 1, 2, 3, 7, 5 };
            Solution.subarraySum(ar, number, sum).ForEach(p => Console.Write(p + " "));

        }
    }

    class Solution
    {
         //Function to find a continuous sub-array which adds up to a given number.
        public static List<int> subarraySum(int[] arr, int n, int s)
        {
            int total = 0;
            List<int> vs = new List<int>();
            for (int j = 0; j < n; j++)
            {
                for (int k = j; k < n; k++)
                {
                    total = arr[k] + total;

                    if (total == s)
                    {
                        //first index
                        vs.Add(j+1);
                        //last index
                        vs.Add(k+1);
                        break;
                        
                    }   
                }
                if (vs.Count > 0)
                {
                    break;
                }
                
                total = 0;
            }
            return vs;
        }



        public static void subarraySum1(int[] arr, int n, int sum)
        {

            // Pick a starting point
            for (int i = 0; i < n; i++)
            {
                int currentSum = arr[i];

                if (currentSum == sum)
                {
                    Console.WriteLine("Sum found at indexe " + i);
                    return;
                }
                else
                {

                    // Try all subarrays starting with 'i'
                    for (int j = i + 1; j < n; j++)
                    {
                        currentSum += arr[j];

                        if (currentSum == sum)
                        {
                            Console.WriteLine("Sum found between indexes " + i + " and " + j);
                            return;
                        }
                    }
                }
            }
            Console.WriteLine("No subarray found");
            return;
        }

    }
}
