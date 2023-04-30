using System;
using System.Collections.Generic;
using System.Text;

namespace Introductiontoc
{
    class NullableCoalescing
    {
        public static void Main()
        {
            int? TicketsForSale;
            Console.WriteLine("Pls Insert the number of tickets for sale");
            string input = Console.ReadLine();
            TicketsForSale = Convert.ToInt32(input);

            int AvailableTickets = 0;
            AvailableTickets = TicketsForSale ?? 0;
            Console.WriteLine("Tickets available for sells are {0}", AvailableTickets);

        }
            


        }
    }

