using System;

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;


namespace hackerrank1
{
    class Program
    {


        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            Result.plusMinus(arr);
        }



        class Result
        {



            /*
           * Complete the 'plusMinus' function below.
           *
           * The function accepts INTEGER_ARRAY arr as parameter.
           */

            public static void plusMinus(List<int> arr)
            {
                float totalnum = 0;
                float    zero = 0;
                float positiveNum = 0;
                float NegativeNum = 0;

                foreach (int ele in arr)
                {
                    totalnum = totalnum + 1;
                    if (ele == 0)
                    {
                        zero = zero + 1;

                    }
                    else if (ele > 0)
                    {
                        positiveNum = positiveNum + 1;

                    }
                    else if (ele<0)
                    {
                        NegativeNum = NegativeNum + 1;
                    }

                }

                //postive ratio calculation
                double pratio = positiveNum/(float)totalnum;
                //-ve ratio
                double nratio = NegativeNum / (float)totalnum;
                //zero ratio
                double zratio = zero / (float)totalnum;
                Console.WriteLine("{0:N6}", pratio);
                Console.WriteLine("{0:N6}",nratio);
                Console.WriteLine("{0:N6}",zratio);
                Console.ReadLine();
             



            }

        }


    }
}

