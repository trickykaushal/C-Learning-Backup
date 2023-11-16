using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5
{
    public class Class1
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public void DisplayAreaAndPerimeter()
        {
            double area = getArea();
            double perimeter = getPermiter();

            Console.WriteLine($"Area: {area}");
            Console.WriteLine($"Perimeter: {perimeter}");
        }

        private double getPermiter()
        {
            return 2 * (Length + Width);
        }

        private double getArea()
        {
            return Length * Width;
        }
    }
}