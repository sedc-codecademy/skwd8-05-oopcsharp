using PreparationSolution.Enums;
using PreparationSolution.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PreparationSolution.Helpers
{
    public class MoviesHelper
    {
        public static List<Movie> GetAllMovies()
        {
            return new List<Movie>
            {
                new Movie { Title = "John Wick", Rating = 7.4, Genre = Genre.Action, Duration = 101, Year = 2014 },
                new Movie { Title = "Die Hard", Rating = 8.2, Genre = Genre.Action, Duration = 132, Year = 1988 },
                new Movie { Title = "The Expendables", Rating = 6.5, Genre = Genre.Action, Duration = 103, Year = 2010 },
                new Movie { Title = "The Godfather", Rating = 9.2, Genre = Genre.Drama, Duration = 175, Year = 1972 },
                new Movie { Title = "Saving private Ryan", Rating = 8.6, Genre = Genre.Drama, Duration = 169, Year = 1998 },
                new Movie { Title = "The silence of the Lammbs", Rating = 8.6, Genre = Genre.Thriller, Duration = 118, Year = 1991 },
                new Movie { Title = "Seven", Rating = 8.6, Genre = Genre.Thriller, Duration = 127, Year = 1995 },
                new Movie { Title = "Inception", Rating = 8.8, Genre = Genre.Thriller, Duration = 148, Year = 2010 },
                new Movie(){ Title = "Thor", Rating = 7, Genre = Genre.SciFi, Duration = 115, Year = 1011 },
                new Movie(){ Title = "Avengers: Endgame", Rating = 8.4, Genre = Genre.SciFi, Duration = 181, Year = 2009 },
                new Movie(){ Title = "Iron Man", Rating = 7.9, Genre = Genre.SciFi, Duration = 126, Year = 2008 }
            };
        }
    }
}
