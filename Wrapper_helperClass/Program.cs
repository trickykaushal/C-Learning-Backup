using System;
using System.Collections.Generic;
using System.Linq;

namespace Wrapper_helperClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            string lowerCase = "pragim";

            string returnstring = lowerCase.GenerateLowerCase();
            Console.WriteLine(returnstring);
            Student student1 = new Student("Kaushal", 67);
            Student student2 = new Student("Ramesh", 53);
            List<Student> ls = new List<Student>();
            ls.Add(student1);
            ls.Add(student2);
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            IEnumerable<int> vs = numbers.Where(num => num > 2);
           
            foreach(int k in vs)
            {
                Console.WriteLine(k + "\n");

            }


            


            

        }
    }
    class Student
    {
        string name;
        int age;

        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
