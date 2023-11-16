using System;

namespace Prints
{
    public class CustomPrint
    {
        public CustomPrint(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        [ObsoleteAttribute("Pls Dont use this one.")]
        public void print()
        {
            Console.WriteLine("Printing from normal method");

        }

        public string Getname()
        {
            return Name;
        }
        public void PrintName()
        {
            Console.WriteLine($"Name is {Name}");

        }
        public void Print(string name)
        {
            Console.WriteLine($"Name is {name}");

        }
        public static string StaticName => "Static Name";

    }
}
