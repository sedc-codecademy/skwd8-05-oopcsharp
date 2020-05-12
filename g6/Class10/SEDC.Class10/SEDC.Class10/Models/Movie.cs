using System;

namespace SEDC.Class10.Models
{
    public class Movie
    {
        public string Name { get; set; }
        public int Genre { get; set; }
        public int Rating { get; set; }
        public int TicketPrice { get; set; }

        public Movie(int rating, string name, string genre)
        {
            if (rating >= 1 && rating <= 5)
            {
                Rating = rating;
            }
            else
            {
                throw new Exception("Rating is not valid");
            }
            Name = name;
            Genre = genre;
            TicketPrice = 5 * Rating;
        }
    }
}