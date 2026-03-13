using Assignment_6.MovieTicketBookingSystem.Interfaces;
using System;


namespace Assignment_6.MovieTicketBookingSystem.Class
{
    internal partial class Cinema
    {
        // Handles cinema control + ticket storage
        public string CinemaName { get; set; }
        private Projector projector = new Projector(); // Composition
        private Ticket[] tickets = new Ticket[20];
        public Cinema(string name)
        {
            CinemaName = name;
        }
        // Add Ticket
        public bool AddTicket(Ticket t)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == null)
                {
                    tickets[i] = t;
                    return true;
                }
            }
            Console.WriteLine("Cinema is full!");
            return false;
        }
        //c.OpenCinema() and CloseCinema() — start/stop the projector.
        public void OpenCinema()
        {
            Console.WriteLine("========== Cinema Opened ==========");
            projector.Start();
        }
        public void CloseCinema()
        {
            projector.Stop();
            Console.WriteLine("========== Cinema Closed ==========");
        }
    }
}
