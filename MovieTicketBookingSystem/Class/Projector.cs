using System;

namespace Assignment_6.MovieTicketBookingSystem.Class
{
    internal class Projector
    {
        //a Projector object (created inside Cinema)
        public void Start()
        {
            Console.WriteLine("Projector ON\n");
        }

        public void Stop()
        {
            Console.WriteLine("\nProjector OFF");
        }
    }
}
