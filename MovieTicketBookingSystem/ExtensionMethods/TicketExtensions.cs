using Assignment_6.MovieTicketBookingSystem.Class;
using System;

namespace Assignment_6.MovieTicketBookingSystem.ExtensionMethods
{
    internal static class TicketExtensions
    {

        public static string GetReceipt(this Ticket t)
            =>
    $@"========== RECEIPT ==========
  Movie    : {t.MovieName}
  Type     : {t.GetType().Name}
  Price    : {t.Price}
  Final    : {t.CalculateFinalPrice():F2}
  Status   : {(t.IsBooked ? "Booked" : "Not Booked")}
=============================";

        public static decimal TotalRevenue(this Ticket[] tickets)
        {
            decimal total = 0;

            foreach (var t in tickets)
            {
                total += t.CalculateFinalPrice();
            }

            return total;
        }
    
    }
}
