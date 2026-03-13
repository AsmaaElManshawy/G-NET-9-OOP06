using System;

namespace Assignment_6.MovieTicketBookingSystem.Interfaces
{
    internal interface IBookable
    {
        // Book only once
        bool Book();
        // Cancel only if booked
        bool Cancel();
    }
}
