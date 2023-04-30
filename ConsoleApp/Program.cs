using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int bill = 0;
            Console.WriteLine("Hello World!");
            Start:
            Console.WriteLine("Welcome To COffee WOrld");

            Console.WriteLine("Press 1 to buy small \n Press 2 to buy medium \n Press 3 to buy large\n press 5 for array check");
            string PreSelection=Console.ReadLine();
            int UserSelection;
            int.TryParse(PreSelection, out UserSelection);


            if (UserSelection == 4)
            {
                goto secondProgram;
            }
           if (UserSelection == 6)
            {
                goto secondProgram;
            }
             if (UserSelection == 5) 
            {
                goto thirdProgram;
            }

            if (UserSelection == 1)
            {
                Console.WriteLine("You Pressed {0} to by small", UserSelection);
                bill += 1;
            }
            if (UserSelection == 2)
            {
                Console.WriteLine("You Pressed {0} to by medium", UserSelection);
                bill += 2;
            }
            if(UserSelection == 3)
            {
                Console.WriteLine("You Pressed {0} to by Large", UserSelection);
                bill += 2;
            }
            else
            {
                Console.WriteLine("Your selection is invalid Pls select again from the list of menus");
                goto Start;
            }
            rechoice:
            Console.WriteLine("Do You want to buy again? \n press y for yes and n for no");
            string NewSelection =Console.ReadLine();
            string k = NewSelection.ToUpper();


            if (k == "Y")
            {
                goto Start;

            }
            else if (k == "N")
            {
                Console.WriteLine("Thank You for shopping");
                Console.WriteLine("Your bill is {0} $", bill);
            }
            else
            {
                Console.WriteLine("Your choice is invalid pls select again");
                goto rechoice;
            }
            secondProgram:
            //while loop
            int newk = 89;

            while (newk >= UserSelection)
            {

                Console.WriteLine("New value is {0}",newk);
                newk += 1;

            }
        thirdProgram:
            {
                int[] kaushal = {5,5,5,5,5,5,5,5,55,6,5,5,5,5,5,5,5,5,5,5};
                foreach(int kaushalin in kaushal)
                {
                    Console.WriteLine(kaushalin);
                }
            }


            



        }
    }
}
