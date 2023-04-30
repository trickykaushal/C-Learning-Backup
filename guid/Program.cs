using System;

namespace guid
{
    class Program
    {
        static void Main(string[] args)
        {
            Guid guid = Guid.NewGuid();
            string k = Convert.ToString(guid);



            Console.WriteLine(k);
        }
    }
}
