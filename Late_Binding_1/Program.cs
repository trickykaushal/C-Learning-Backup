using System;
using System.Reflection;

namespace Late_Binding_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly Executingassembly = Assembly.GetExecutingAssembly();
            Type type = Executingassembly.GetType("Late_Binding_1.Customer");
            object d = Activator.CreateInstance(type);
            MethodInfo get_name=type.GetMethod("GetFull_name");
            String[] Parameters = new string[2];
            Parameters[0] = "Kaushal";
            Parameters[1] = "Manoj";
          string k=(string)get_name.Invoke(d,Parameters);
            Console.WriteLine(k);
            




           
        }
    }
    public class Customer
    {
        public static string GetFull_name(string first_name, string Last_name)
        {
            return first_name + " " + Last_name;
        }
    }
}
