using System;

namespace Assignment_6.MovieTicketBookingSystem.Class
{
    internal class Projector
    {
        //a Projector object (created inside Cinema)
        public void Start()
        {
            Console.WriteLine("Projector ON");
        }

        public void Stop()
        {
            Console.WriteLine("Projector OFF");
        }
    }
}
