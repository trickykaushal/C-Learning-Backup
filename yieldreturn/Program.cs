using System;
using System.Text;
namespace reference
{
    class MyObject:Person
    {
        public static void Main()
        {
            Person p = new Person();

            p.firstName = "firstKaushal";
            p.LastName = "Patel";


          getName(ref p);
            Console.WriteLine("FUll name is {0} ",p.firstName+" "+p.LastName);




        }
    }
    class Person
    {
        public string firstName { get; set; }
        public string LastName { get; set; }


        public static void getName(ref Person person)
        {
            person.LastName = "Patel";
            person.firstName = "Kaushal";


        }


    }
}