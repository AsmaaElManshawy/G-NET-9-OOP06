using System;

namespace Assignment_6.MovieTicketBookingSystem.Class
{
    internal class IMAXTicket : Ticket
    {
        public bool Is3D { get; set; }

        public IMAXTicket(string movieName, decimal price, bool is3D) : base(movieName, is3D ? price + 30m : price)
        {
            Is3D = is3D;
        }

        public IMAXTicket(string movieName, bool is3D) : base(movieName)
        {
            Is3D = is3D;
        }

        public override string ToString()
        {
            string type = Is3D ? "Yes" : "No";
            return base.ToString() + $" | IMAX 3D: {type}";
        }

        //2. In each child class, provide its own version of PrintTicket():
        //c.IMAXTicket — prints the base ticket info and whether it is 3D.


        #region Assignment 05

        public override void Print()
        {
            Console.WriteLine($"[Ticket #{TicketId}] {MovieName} | IMAX | 3D: {(Is3D ? "Yes" : "No")} | Price: {Price} | After Tax: {PriceAfterTax} | Booked: {(IsBooked ? "Yes" : "No")}");
        }

        public override object Clone()
        {
            if (Is3D)
                return new IMAXTicket(MovieName, Price - 30m, Is3D);
            else
                return new IMAXTicket(MovieName, Price, Is3D);
        }

        #endregion
    }
}
