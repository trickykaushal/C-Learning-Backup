using System;

namespace ENum
{
    class Program
    {
        static void Main(string[] args)
        {

           string[] names= Enum.GetNames(typeof(Gender));
          foreach(string item in names)
            {
                Console.WriteLine(item);

            }



            long[] vs=(long[])Enum.GetValues(typeof(Gender));
            foreach(int val in vs)
            {
                Console.WriteLine(val);
            }
        }

        public  enum Gender:long
        {
            Male=56,
            Female=798789738945893,
            Unknown=34
        }
    }
   
}
