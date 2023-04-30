using System;
using System.Reflection;
namespace Late_Binding
{
    public class main
    {
        public static void Main()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type type = assembly.GetType("Late_Binding.student");
           MethodInfo methods= type.GetMethod("getfullname");
            object real=Activator.CreateInstance(type);
            string[] parameters = new string[2];
            parameters[0] = "Kaushal";
            parameters[1] = "Manoj";
            string full_name=(string)methods.Invoke(real, parameters);
            Console.WriteLine(full_name);
           
            




        }
    }
    public class student
    {
        public static string getfullname(string first_name, string last_name)
        {
            return first_name + " " + last_name;
        }
    }
}