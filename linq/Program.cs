using System;
using System.Collections.Generic;
using System.Linq;
namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {

            string k = "Kaushal";
            k.GenerateLowerCase();
            Person person1 = new Person(56, "Manoj");
            Person person = new Person(56, "Kaushal");
            List<Person> p1 = new List<Person>();
            p1.Add(person);
            p1.Add(person1);
            var Sel_Val = p1.Where(k => k.Age == 56).Select(x => x.name);
            IEnumerable<int> sel_val2 = from k1 in p1
                                        where k1.name == "Kaushal"
                                        select k1.Age;
            int? value = null;
            foreach (var k2 in sel_val2)
            {
                value = k2;
                
            }

            foreach (var k1 in Sel_Val)
            {
                Console.WriteLine(k1);

            }
            //finding the smallest number in the given list
            int[] vs1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            List<int> vs = vs1.ToList<int>();
            int? result = null;
            //This logic is implemented through c#
            //max logic 
            foreach (var num in vs)
            {
                if (!result.HasValue || num > result)
                {
                    result = num;
                }

            }

            // logic for even number
            foreach (var num in vs)
            {
                if (num % 2 == 0)
                {
                    if (!result.HasValue || num > result)
                    {
                        result = num;
                    }
                }


            }

            //MIn LOgic
            //foreach (var num in vs)
            //{
            //    if (!result.HasValue || num < result)
            //    {
            //        result = num;
            //    }

            //}

            //Same Logic through linq
            var MinNum = vs.Min(x => x);
            var MaxNum = vs.Max(x => x);
            var MaxSum = vs.Sum(x => x);
            var MaxAvg = vs.Average(x => x);
            var Count = vs.Count();
            int AggregateProduct = vs.Aggregate((a, b) => a * b);
            int aggregateseeding = vs.Aggregate(10,(a, b) => a * b);

            Console.WriteLine("This is the product value of this loop {0}", AggregateProduct);

            Console.WriteLine("This is the minimum value of this loop {0}", MinNum);
            Console.WriteLine("This is the average value of this loop {0}", MaxAvg);
            Console.WriteLine("This is the count value of this loop {0}", Count);
            Console.WriteLine("This is the max value of this loop {0}", MaxNum);
            Console.WriteLine("This is the maxSum value of this loop {0}", MaxSum);

            //Here printing the smallest number
            Console.WriteLine(result);
            Console.WriteLine("This is the selected value " + sel_val2);






        }


    }
    class Person
    {
        public Person(int age, string name)
        {
            Age = age;
            this.name = name;
        }

        public int Age { get; set; }
        public string name { get; set; }
    }
}
