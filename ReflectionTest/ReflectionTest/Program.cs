using System;
using System.Reflection;
using Prints;

namespace ReflectionTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Type type = typeof(CustomPrint);
            Type personType = type;
            PropertyInfo[] propertyInfos = personType.GetProperties();

            foreach(PropertyInfo property in propertyInfos)
            {

            }
        }
    }

}
