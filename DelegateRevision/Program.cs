using System;

namespace DelegateRevision
{
    class Program
    {
        //basic delegate
        class Kaushal
        {
            delegate void prinDelegate(string name);
            delegate void printSirNamedel(string name);
            public static void Main()
            {
                prinDelegate prinDelegate = new prinDelegate(printName);
                printSirNamedel printSirNamedel = new printSirNamedel(printSirName);

                prinDelegate("Kaushal");
                printSirNamedel("Patel");
            }
            public  static void printName(string name)
            {
                Console.WriteLine(name);
                Console.ReadLine();
            }


           public static void printSirName(string sirname)
            {
                Console.WriteLine(sirname);
            }
           

        }

        class substituitionPRinciple
        {

        }
    }


}
