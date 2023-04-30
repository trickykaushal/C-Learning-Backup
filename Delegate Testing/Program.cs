using System;
namespace learning
{
    public delegate int LearnDele();
    class learning1
    {
        public static void Main()
        {

            LearnDele del1, del2, del3, del4, del5;
            del1 = new LearnDele(Method1);
            del2 = new LearnDele(Method2);
            del3 = new LearnDele(Method3);
            del4 = new LearnDele(Method4);
            del5 = del1 + del2 + del3 + del4;

            int j = 0;
            j=del5();
            Console.WriteLine("Final Value {0}",j);


        }


        public static int Method1()
        {
                return  1;
        }
        public static int Method2()
        {
            return 2;
        }
        public static int Method3()
        {
            return 3;
        }
        public static int Method4()
        {
            return 4;
        }

    }


    

}