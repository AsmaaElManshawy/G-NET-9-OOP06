using Assignment_6.MovieTicketBookingSystem.Interfaces;
using System;

namespace Assignment_6.MovieTicketBookingSystem.Class
{
    internal abstract class Ticket : IPrintable , IBookable , ICloneable
    {
        private string movieName;
        public string MovieName
        {
            get { return movieName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    movieName = value;
                else
                    throw new ArgumentException("Movie name cannot be empty or whitespace");
            }
        }

        private decimal price;
        public decimal Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                    price = value;
                else
                    throw new ArgumentException("Price must be greater than 0");
            }
        }

        public bool IsBooked { get; private set; }
        // Ticket ID
        public int TicketId { get; }

        // Static counter
        private static int ticketCounter = 0;

        // Constructor
        protected Ticket(string movieName, decimal price)
        {
            MovieName = movieName;
            Price = price;
            ticketCounter++;
            TicketId = ticketCounter;
        }

        protected Ticket(string movieName)
        {
            ticketCounter++;
            TicketId = ticketCounter;
            MovieName = movieName;
        }

        // A static int GetTotalTickets() method that returns the total number of tickets created.
        public static int GetTotalTickets()
        {
            return ticketCounter;
        }

        public override string ToString()
            => $"Ticket #{TicketId} | {MovieName}";

        // Method Overloading
        public void SetPrice(decimal price)
        {
            Price = price;
        }

        public void SetPrice(decimal basePrice, decimal multiplier)
        {
            Price = basePrice * multiplier;
        }

        public bool Book()
        {
            if (IsBooked)
                return false;

            IsBooked = true;
            return true;
        }

        public bool Cancel()
        {
            if (!IsBooked)
                return false;

            IsBooked = false;
            return true;
        }

        public virtual void Print()
        {
            string status = IsBooked ? "Booked" : "Available";

            Console.WriteLine(
                $"Ticket #{TicketId} | {MovieName} | Status: {status}"
            );
        }

        #region Assignment 06
        public abstract object Clone();

        // Abstract method (must be implemented by child classes)
        public abstract decimal CalculateFinalPrice();
        #endregion
    }
}
