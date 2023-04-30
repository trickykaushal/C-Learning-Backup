using System;
using System.IO;

namespace ExceptionTrain
{
    class Program
    {
        public static void Main(string[] args)
        {
            StreamReader reader =null ;
            try
            {
               reader = new StreamReader(@"C:\Users\kaushal.patel\OneDrive - CARE RATINGS LIMITED\Documents\New folder\data.txt");
                Console.WriteLine(reader.ReadToEnd());
            }

            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {

                //This block is used to free all the held resource
                if (reader != null)
                {
                    reader.Close();

                }
             
                Console.WriteLine("FInally Block has been executed");

               
            }


        }

    }

}
