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
            => base.ToString() + $" | Seat: {SeatNumber}";

        public override object Clone()
            => new StandardTicket(MovieName, Price, SeatNumber);

        #region Assignment 05
        public override decimal CalculateFinalPrice() 
            => Price * 1.14m;

        public override void Print()
        {
            Console.WriteLine($"[Ticket #{TicketId}] {MovieName} | Standard | Seat: {SeatNumber} | Price: {Price} | Final: {CalculateFinalPrice():F2} | Booked: {(IsBooked ? "Yes" : "No")}");
        }
        
        #endregion
    }
}
