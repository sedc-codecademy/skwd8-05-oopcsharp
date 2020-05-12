using System.Collections.Generic;

namespace Models
{
    public class MoviesHelper
    {
        public static List<Movie> GetAllActionMovies()
        {
            return new List<Movie>()
            {
                new Movie() {Title = "The Mountain II", Year = 2016, Rating = 8.9f, Duration = 135},
                new Movie() {Title = "Seven Samurai", Year = 1954, Rating = 8.6f, Duration = 207},
                new Movie() {Title = "Big Hero 6", Year = 2014, Rating = 7.8f, Duration = 102},
                new Movie() {Title = "The Man from Nowhere", Year = 2010, Rating = 7.8f, Duration = 119},
                new Movie() {Title = "Gladiator", Year = 2000, Rating = 8.5f, Duration = 155},
                new Movie() {Title = "Avengers: Endgame", Year = 2009, Rating = 8.4f, Duration = 181},
                new Movie() {Title = "Kung Fu Hustle", Year = 2004, Rating = 7.7f, Duration = 99},
                new Movie() {Title = "Iron Man", Year = 2008, Rating = 7.9f, Duration = 126},
                new Movie() {Title = "Big Hero 6", Year = 2014, Rating = 7.8f, Duration = 102},
                new Movie() {Title = "The Dark Knight", Year = 2008, Rating = 9.0f, Duration = 152},
                new Movie() {Title = "13 Assassins", Year = 2010, Rating = 7.6f, Duration = 141},
                new Movie() {Title = "Grindhouse", Year = 2007, Rating = 7.5f, Duration = 191}
            };
        }
    }
}
