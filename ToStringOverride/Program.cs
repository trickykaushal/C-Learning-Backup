using System;

namespace ToStringOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Last_name = "Patel";
            customer.first_name = "Kaushal";
            Console.WriteLine(customer.ToString());

            
         
        }
    }
    public class Customer
    {
        public string first_name { get; set ; }
        public string Last_name { get; set ; }

        public override string ToString()
        {
            return first_name + " ," + Last_name;
        }
        
    }
}
