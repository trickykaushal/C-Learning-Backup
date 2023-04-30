using System;
using System.Collections.Generic;
using System.Text;

namespace PracOpen
{
    // as this module is dependent on smaller class or module so we will use 

    //--Dependency Inversion Principle
    //class EmployeeManagement
    //{
    //    public float hourworked { get; set; }
    //    public float hourlyrate { get; set; }
    //    public EmployeeManagement(float hourworrked, float hourlyrate)
    //    {
    //        this.hourworked = hourworrked;
    //        this.hourlyrate = hourlyrate;
    //    }
    //    public float Getsalary(float hourworked, float hourlyrate)
    //    {
    //        var salarycalculatore = new SalaryCalculator();
    //        return salarycalculatore.GenerateSalary(hourworked, hourlyrate);
    //    }
    //}
    //class SalaryCalculator
    //{
    //    public float GenerateSalary(float hourworked, float hourlyrate)
    //    {
    //        return hourworked * hourlyrate;
    //    }
    //}


    //// By Dependency Inversion Principle
    //public interface ISalaryCalculator
    //{
    //    public float GenerateSalary(float hourworked, float hourlyrate);

    //}
    //public class Salary : ISalaryCalculator
    //{
    //    public float GenerateSalary(float hourworked, float hourlyrate) => hourworked * hourlyrate;


    //}

    //public class EmployeeManagement
    //{
    //    public float hourworked { get; set; }
    //    public float hourlyrate { get; set; }
    //    private readonly ISalaryCalculator _salaryCalculator;

    //    public EmployeeManagement(ISalaryCalculator salary)
    //    {
    //        _salaryCalculator = salary;
    //    }


    //    public float GenerateSalary()
    //    {
    //        return _salaryCalculator.GenerateSalary(hourworked, hourlyrate);
    //    }
    //}


    class employeeManage
    {
        private int workhour;
        private float workingSal;
        public readonly IGensalary _Gensalary;

        public employeeManage(IGensalary Gensalary)
        {
            _Gensalary= Gensalary;
        } 

        public int Workhour { get => workhour; set => workhour = value; }
        public float WorkingSal { get => workingSal; set => workingSal = value; }
      

        public float CalcSalary()
        {
            return _Gensalary.calcSalary(Workhour, workingSal);
        }
        //public float genearatesalary()
        //{
        //    //Gensalary gensalary = new Gensalary();
        //    return gensalary.calcSalary(workhour, workingSal);
        //}


    }

    public interface IGensalary
    {

        public float calcSalary(int workhour, float workingSal);

    }

    public class salaryGenerate : IGensalary
    {
        public float calcSalary(int workhour, float workingSal)
        {
            return workhour * workingSal;
        }
    }



}

