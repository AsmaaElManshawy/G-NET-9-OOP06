using System;

namespace Assignment_6.MovieTicketBookingSystem.Class
{
    internal class IMAXTicket : Ticket
    {
        public bool Is3D { get; set; }

        public IMAXTicket(string movieName, decimal price, bool is3D) : base(movieName, price)
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


        public override object Clone()
                => new IMAXTicket(MovieName, Price, Is3D);

        #region Assignment 05

        public override decimal CalculateFinalPrice()
        {
            if (Is3D)
            {
                return (Price + 30) * 1.14m;
            }
            return Price * 1.14m;
        }

        public override void Print()
        {
            Console.WriteLine($"[Ticket #{TicketId}] {MovieName} | IMAX | 3D: {(Is3D ? "Yes" : "No")} | Price: {Price} | Final: {CalculateFinalPrice():F2} | Booked: {(IsBooked ? "Yes" : "No")}");
        }

        #endregion
    }
}
