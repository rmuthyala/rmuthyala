using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullCoalescingOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int ? TicketsOnSale = 10;
            int AvailableTickets = TicketsOnSale ?? 0;
            Console.WriteLine("Available tickets = {0}", AvailableTickets);
        }
    }
}
