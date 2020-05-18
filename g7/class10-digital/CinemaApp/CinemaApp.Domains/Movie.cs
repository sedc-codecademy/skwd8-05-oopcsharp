using System;
using CinemaApp.Domains.Enums;

namespace CinemaApp.Domains
{
    public class Movie
    {
        public Movie(string title, Genre genre,short rating, double ticketPrice)
        {
            Title = title;
            Genre = genre;
            if (rating < 0 || rating > 5)
            {
                throw new Exception("The rating can not be higher then 6 or less then 1");
            }
            Rating = rating;
            TicketPrice = 5 * rating;
        }
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public short Rating { get; set; }
        public double TicketPrice { get; set; }
    }
}
