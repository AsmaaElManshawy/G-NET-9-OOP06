using System;

namespace Assignment_6.MovieTicketBookingSystem.Class
{
    internal class StandardTicket : Ticket
    {
        public string SeatNumber { get; set; }

        public StandardTicket(string movieName, decimal price, string seatNumber) : base(movieName, price)
        {
            SeatNumber = seatNumber;
        }

        public StandardTicket(string movieName, string seat) : base(movieName)
        {
            SeatNumber = seat;
        }

        public override string ToString()
        {
            return base.ToString() + $" | Seat: {SeatNumber}";
        }


        //2. In each child class, provide its own version of PrintTicket():
        //a.StandardTicket — prints the base ticket info and the SeatNumber.

        #region Assignment 05

        public override void Print()
        {
            Console.WriteLine($"[Ticket #{TicketId}] {MovieName} | Standard | Seat: {SeatNumber} | Price: {Price} | After Tax: {PriceAfterTax} | Booked: {(IsBooked ? "Yes" : "No")}");
        }

        public override object Clone()
        {
            return new StandardTicket(MovieName, Price, SeatNumber);
        }

        #endregion
    }
}
