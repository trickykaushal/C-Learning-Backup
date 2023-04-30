using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            var prevDate = new DateTime(2021, 7, 15); //15 July 2021
            var today = DateTime.Now;
            TimeSpan ts = new TimeSpan();
            ts = today - prevDate;
            Console.WriteLine("Number of days {0}", (ts.Days));

            //get difference of two dates
            var diffOfDates = today - prevDate;

            Console.WriteLine("Difference in Timespan: {0}", diffOfDates);
            Console.WriteLine("Difference in Days: {0}", diffOfDates.Days);
            Console.ReadLine();
            //Console.WriteLine("Difference in Hours: {0}", diffOfDates.Hours);
            //Console.WriteLine("Difference in Miniutes: {0}", diffOfDates.Minutes);
            //Console.WriteLine("Difference in Seconds: {0}", diffOfDates.Seconds);
            //Console.WriteLine("Difference in Milliseconds: {0}", diffOfDates.Milliseconds);
            //Console.WriteLine("Difference in Ticks: {0}", diffOfDates.Ticks);
     
        }
    }
}
