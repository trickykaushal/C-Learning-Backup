using System;
using System.Text;
using System.Web;

namespace StringBuilderVsSystem.String
{
    class Program
    {





        static void Main(string[] args)
        {


            // In this SysText System will create new reference every time we add new text in it therefore this is mutable

            //string SysText = "HI";
            //SysText += " This";
            //SysText += " Kaushal";
            //SysText += " Manoj";
            //SysText += " Patel";
            //Console.WriteLine(SysText);

            StringBuilder SysText = new StringBuilder();
            SysText.Append("Hi");
            SysText.Append("Hi");
            SysText.Append("Hi");
            SysText.Append("Hi");
            SysText.Append("Hi");
            SysText.Append("Hi");
            SysText.AppendLine("Hi");
            SysText.AppendLine("Hi"); SysText.AppendLine("Hi");
            SysText.AppendLine("Hi"); SysText.AppendLine("Hi");

            SysText.Append("Hi");
            SysText.Append("Hi");
            SysText.Append("Hi");
            SysText.Append("Hi");
            SysText.Append("Hi");
            SysText.Append("Hi");
            Console.WriteLine(SysText);

            

        }
    }
}
