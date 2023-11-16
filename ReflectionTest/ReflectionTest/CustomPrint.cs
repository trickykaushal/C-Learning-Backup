using System;

namespace Prints
{
    public class CustomPrint
    {
        public CustomPrint(string name)
        {
            Name_kaushal = name;
        }

        public string Name_kaushal { get; set; }

        [ObsoleteAttribute("Pls Dont use this one.")]
        public void print()
        {
            Console.WriteLine("Printing from normal method");

        }

        public string Getname()
        {
            return Name_kaushal;
        }
        public void PrintName()
        {
            Console.WriteLine($"Name is {Name_kaushal}");

        }
        public void Print(string name)
        {
            Console.WriteLine($"Name is {name}");

        }
        public static string StaticName => "Static Name";

    }
}
