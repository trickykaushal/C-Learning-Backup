using System;
namespace ConsoleApp1
{



    public class Employee
    {
        public String FName;
        public String LName;
        //public Employee()
        //{
        //    Console.WriteLine("Parent Class Constructor is called");
        //}
        //public Employee(string MyName)
        //{
        //    Console.WriteLine("My name is {0}", MyName);
        //}


        public void FullName()
        {
            Console.WriteLine("THis is parent Class");
        }


    }

    public class PermanentEmployee : Employee
    {

        public new  void FullName()

        {
          

            Console.WriteLine("Permanent Employee class");
        }

    }
    public class PartEmployee : Employee
    {
        //public void FullName()
        //{
        //    Console.WriteLine("My Name is");
        //}

        public new  void FullName()
        {
            Console.WriteLine("Full Name is Base Class");
        }
    }
    class Program
    {
        public static void Main()
        {
            //ChildClass CC = new ChildClass();

            //CC.FName = "Kaushal";
            //CC.LName = "Patel";
            //Console.WriteLine("My name is {0} {1}", CC.FName, CC.LName);


          PartEmployee pe=new PartEmployee();
            ((Employee)pe).FullName();
       


        }
    }

}



