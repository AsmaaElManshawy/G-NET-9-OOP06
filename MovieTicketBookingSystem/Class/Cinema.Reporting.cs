using Assignment_6.MovieTicketBookingSystem.Interfaces;
using System;

namespace Assignment_6.MovieTicketBookingSystem.Class
{
    internal partial class Cinema
    {
        // Handles printing / reports
        // Indexer
        public Ticket this[int index]
        {
            get
            {
                if (index >= 0 && index < tickets.Length)
                    return tickets[index];
                return null;
            }
            set
            {
                if (index >= 0 && index < tickets.Length)
                    tickets[index] = value;
            }
        }
        public void PrintAllTickets()
        {
            Console.WriteLine("--- All Tickets (from Cinema.Reporting) ---");

            foreach (IPrintable t in tickets)
            {
                if (t != null)
                {
                    t.Print();
                }
            }

            Console.WriteLine();
        }
        public static void ProcessTicket(Ticket t)
        {
            Console.WriteLine("\n========== Process Single Ticket ==========");
            t.Print();
        }
        // Get Movie By Name
        public Ticket GetMovieByName(string movieName)
        {
            foreach (var ticket in tickets)
            {
                if (ticket != null && ticket.MovieName.Equals(movieName, StringComparison.OrdinalIgnoreCase))
                    return ticket;
            }
            return null;
        }
    }
}
