using System;

namespace Ticket_system_2
{
    class TicketStats
    {
        private static int open{get;set;}=0;
        private static int closed{get;set;}=0;
        private static int reopen{get;set;}=0;
        public static void TicketStatistics(int Open,int Closed,int Reopen,int total)
        {   //Has the ticket counts passed to the method then writes to console the number.
            int OpenTickets=Open;
            int ClosedTickets=Closed;
            int ReopenTickets=Reopen;
            int TotalTickets=total;
            Console.WriteLine("Ticket:\n");
            Console.WriteLine("\nTotal Tickets: "+total);
            Console.WriteLine("\nOpen Tickets: "+Open);
            Console.WriteLine("\nClosed Tickets: "+Closed);
            Console.WriteLine("\nReopened Tickets: "+Reopen);
        }
    }
}