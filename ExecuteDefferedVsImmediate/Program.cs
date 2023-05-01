using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace ExecuteDefferedVsImmediate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = Student.GetStudents();
            var AllStudent = students.Where(x => x.Marks > 700).Select(x => x).Count();

            students.Add(new Student { Name = "Vinod", Marks = 890 });
            Console.WriteLine($"COunt is {AllStudent}");


            //foreach(var k in AllStudent)
            //{

            //    Console.WriteLine($"{k.Name} and the marks si : {k.Marks}");
            //}
        }
    }
}
