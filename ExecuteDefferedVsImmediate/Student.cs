using System;
using System.Collections.Generic;
using System.Text;

namespace ExecuteDefferedVsImmediate
{
    class Student
    {
        //public Student(int marks, string name)
        //{
        //    Marks = marks;
        //    Name = name;
        //}

        public int Marks { get; set; }
        public string Name { get; set; }

        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student> {
                 new Student { Marks = 500, Name = "Kaushal" } ,
                 new Student { Marks = 600, Name = "Manoj" } ,
                 new Student { Marks = 700, Name = "Patel" } ,
                 new Student { Marks = 800, Name = "Kajal" } ,
                 new Student { Marks = 900, Name = "Garima" }
                };
            return students;

        }

    }
}
