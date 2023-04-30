using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency_Inversion
{
    class Employee 
    {
        private int working_hour;
        private float minimumwage;
        private IGenSalary genSalary;

        public Employee(IGenSalary genSalary)
        {
            GenSalary = genSalary;
        }

        public int Working_hour { get => working_hour; set => working_hour = value; }
        public float Minimumwage { get => minimumwage; set => minimumwage = value; }
        public IGenSalary GenSalary { get => genSalary; set => genSalary = value; }

        public float getSalary()
        {
            return GenSalary.CalcSal(Working_hour, Minimumwage);
           
        }



    }
    public interface IGenSalary
    {
        public float CalcSal(int workinghour, float minimumwage);


    }
    public class Salary : IGenSalary
    {
        public float CalcSal(int workinghour, float minimumwage)
        {
            return workinghour * minimumwage;
        }
    }
}


