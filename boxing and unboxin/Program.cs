using System;

namespace boxing_and_unboxin
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 10;
            Console.WriteLine(j);
            studetnt s1 = new studetnt("kausahl",23);


            int myage = s1.Age;
            Console.WriteLine(myage);

        }
    }
    class studetnt
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public studetnt(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
