using System;

namespace Assignment_6.MovieTicketBookingSystem.Class
{
    internal sealed class VIPTicket : Ticket
    {
        public bool LoungeAccess { get; set; }
        public decimal ServiceFee { get; } = 50m;

        public VIPTicket(string movieName, decimal price, bool loungeAccess) : base(movieName, price)
        {
            LoungeAccess = loungeAccess;
        }

        public VIPTicket(string movieName, bool loungeAccess) : base(movieName)
        {
            LoungeAccess = loungeAccess;
        }

        public override string ToString()
        {
            string lounge = LoungeAccess ? "Yes" : "No";
            return base.ToString() + $" | Lounge: {lounge} | Service Fee: {ServiceFee} EGP";
        }

        public override object Clone()
            => new VIPTicket(MovieName, Price, LoungeAccess);

        #region Assignment 05
        public override decimal CalculateFinalPrice()
            => (Price + ServiceFee) * 1.14m;

        public override void Print()
        {
            Console.WriteLine($"[Ticket #{TicketId}] {MovieName} | VIP | Lounge: {(LoungeAccess ? "Yes" : "No")} | Fee: {ServiceFee} | Price: {Price} | Final: {CalculateFinalPrice():F2} | Booked: {(IsBooked ? "Yes" : "No")}");
        }

        #endregion
    }
}
