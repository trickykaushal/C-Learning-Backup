using System;
using System.Collections.Generic;
namespace delegatelearing
{
    //basic delegate
    class Kaushal
    {
        delegate void printcheck(string msg);
        public static void Main()
        {
            printcheck newcheck = new printcheck(hello);
            newcheck("This is the best of me");

        }
        public static void hello(string Msg)
        {
            Console.WriteLine(Msg);

        }

    }
    

}