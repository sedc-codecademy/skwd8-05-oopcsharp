using CinemaApp.Domains.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaApp.Domains
{
    // 1. Movie must have: Title, Genre, Rating, TicketPrice and a constructor for setting them
    // 2. Rating should be a number from 1 to 5. Throw exception if its more or less ( you should also handle other exceptions )
    // 3. Set the TicketPrice to be 5 * Rating when creating a new object
    // 4. Genre should be an enum with Comedy, Horror, Action, Drama and SciFi
    public class Movie
    {
        public Movie() { }
        public Movie (string title, Genre genre, short rating) // , double TicketPrice
        {
            Title = title;
            Genre = genre;
            if(rating < 1 || rating > 5)
            {
                throw new Exception("The rating can not be smaller than 1 and bigger than 5!");
            }
            Rating = rating;
            TicketPrice = 5 * Rating;
        }
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public short Rating { get; set; }
        public double TicketPrice { get; set; }
    }
}
