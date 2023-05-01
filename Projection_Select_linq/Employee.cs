using System;
using System.Collections.Generic;
using System.Text;

namespace Projection_Select_linq
{
    public class Employee
    {
        private int employee_id;
        private int salary;
        private string empName;
        private List<string> subjects;

        public Employee(int employee_id, int salary, string empName,List<string > subject)
        {
            Employee_id = employee_id;
            Salary = salary;
            EmpName = empName;
            Subjects = subject;
        }

        public int Employee_id { get => employee_id; set => employee_id = value; }
        public int Salary { get => salary; set => salary = value; }
        public string EmpName { get => empName; set => empName = value; }
        public List<string> Subjects { get => subjects; set => subjects = value; }

        public static List<Employee> GetEmployees()
        {
            List<Employee> ls = new List<Employee> {
                new Employee(1234,354545,"Manoj",new List<string> { "hindi", "English","Marathi"}),
                new Employee(124, 34234, "Kaushal",new List<string> { "hindi", "English","Marathi"}),
                new Employee(124, 34234, "Kaushal",new List<string> { "hindi", "English","Marathi"}),
                new Employee(124, 34234, "Kaushal",new List<string> { "hindi", "English","Marathi"}),
                new Employee(124, 34234, "Kaushal",new List<string> { "hindi", "English","Marathi"}),
                new Employee(124, 34234, "Kaushal",new List<string> { "hindi", "English","Marathi"}),
                new Employee(124, 34234, "Kaushal",new List<string> { "hindi", "English","Marathi"}),
                new Employee(124, 34234, "Kaushal",new List<string> { "hindi", "English","Marathi"}),
                new Employee(124, 34234, "Kaushal",new List<string> { "hindi", "English","Marathi"}),
                new Employee(124, 34234, "Kaushal",new List<string> { "hindi", "English","Marathi"}),
                new Employee(124, 34234, "Kaushal",new List<string> { "hindi", "English","Marathi"}),
                new Employee(124, 34234, "Kaushal",new List<string> { "hindi", "English","Marathi"}),
                new Employee(124, 34234, "Kaushal",new List<string> { "hindi", "English","Marathi"}),
                new Employee(124, 34234, "Kaushal",new List<string> { "hindi", "English","Marathi"}),
                new Employee(124, 34234, "Kaushal",new List<string> { "hindi", "English","Marathi"}),
                new Employee(12344,5345345,"Patel",new List<string> { "hindi", "English","Marathi"}),
                new Employee(12344,5345345,"Patel",new List<string> { "hindi", "English","Marathi"})};
           

            return ls;
        }
    }
    public class Subject
    {
        List<Subject> subjects;
        public List<Subject> Subjects { get => subjects; set => subjects = value; }
    }
}
