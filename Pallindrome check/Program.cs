using System;

namespace Pallindrome_check
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the word to check wether it is pallindrome or not?");
            string pal_word = Console.ReadLine();
           
            char[] rev_pal_word=pal_word.ToCharArray();
            Console.WriteLine(rev_pal_word);
            char[] rev_word = new char[rev_pal_word.Length];
            
            for (int i=rev_pal_word.Length-1;i>=0; i--)
            {
                rev_word[(rev_pal_word.Length-1) - i] = rev_pal_word[i];

            }
            string k = new string(rev_word);
            string k2 = new string(rev_pal_word);

            if (k.Equals(k2))
            {
                Console.WriteLine("The given word is pallindrome");
            }
            else
            {
                Console.WriteLine("THe given word is not a pallindrome");
            }

          



        }
        //public static string stringReverseString1(string str)
        //    {
        //        char[] chars = str.ToCharArray();
        //        char[] result = newchar[chars.Length];
        //        for (int i = 0, j = str.Length - 1; i < str.Length; i++, j--)
        //        {
        //            result[i] = chars[j];
        //        }
        //        return new string(result);
        //    }
    }
}
