using System;

namespace ToStringOverride_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.First_Name = "Kaushal";
            customer.Last_Name = "Patel";
            Console.WriteLine(customer.ToString());

        }
    }
    public class Customer
    {
   public string First_Name { get; set; }
   public string Last_Name { get; set; }


        public override string ToString()
        {
            return this.First_Name + " " + this.Last_Name;
        }
    }
}
