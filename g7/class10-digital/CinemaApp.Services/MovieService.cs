using CinemaApp.Domains;
using System;
using System.Collections.Generic;
using CinemaApp.Domains.Enums;
using System.Linq;

namespace CinemaApp.Services
{
    public static class MovieService
    {
        public static List<Movie> GenerateMoviesForCineplexx()
        {
            Movie movie1 = new Movie("Scary Movie", Genre.Comedy, 4, 2.5);
            Movie movie2 = new Movie("American Pie", Genre.Comedy, 4, 2.5);
            Movie movie3 = new Movie("Saw", Genre.Horror, 4, 2.5);
            Movie movie4 = new Movie("The Shining", Genre.Horror, 4, 2.5);
            Movie movie5 = new Movie("Rambo", Genre.Action, 4, 2.5);
            Movie movie6 = new Movie("The Terminator", Genre.Action, 4, 2.5);
            Movie movie7 = new Movie("Forrest Gump", Genre.Drama, 4, 2.5);
            Movie movie8 = new Movie("12 Angru Men", Genre.Drama, 4, 2.5);
            Movie movie9 = new Movie("Passengers", Genre.SiFi, 4, 2.5);
            Movie movie10 = new Movie("Interstellar", Genre.SiFi, 4, 2.5);
            return new List<Movie> { movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8, movie9, movie10 };
        }

        public static List<Movie> GenerateMoviesForMilenium()
        {
            Movie movie11 = new Movie("Airplane", Genre.Comedy, 4, 2.5);
            Movie movie12 = new Movie("Johnny English", Genre.Comedy, 4, 2.5);
            Movie movie13 = new Movie("The Ring", Genre.Horror, 4, 2.5);
            Movie movie14 = new Movie("Sinister", Genre.Horror, 4, 2.5);
            Movie movie15 = new Movie("RoboCop", Genre.Action, 4, 2.5);
            Movie movie16 = new Movie("Judge Dredd", Genre.Action, 4, 2.5);
            Movie movie17 = new Movie("The Social Network", Genre.Drama, 4, 2.5);
            Movie movie18 = new Movie("The Shawshank Redemption", Genre.Drama, 4, 2.5);
            Movie movie19 = new Movie("Inception", Genre.SiFi, 4, 2.5);
            Movie movie20 = new Movie("Avatar", Genre.SiFi, 4, 2.5);
            return new List<Movie> { movie11, movie12, movie13, movie14, movie15, movie16, movie17, movie18, movie19, movie20 };
        }

        public static List<Movie> FilterByGenre(Genre genre,List<Movie> movies)
        {
            //The one liner way
            return movies.Where(m => m.Genre == genre).ToList();

            // // The manual way
            //switch (genre)
            //{
            //    case Genre.Action:
            //        return movies.Where(m => m.Genre == Genre.Action).ToList();
            //    case Genre.Comedy:
            //        return movies.Where(m => m.Genre == Genre.Comedy).ToList();
            //    case Genre.Horror:
            //        return movies.Where(m => m.Genre == Genre.Horror).ToList();
            //    case Genre.Drama:
            //        return movies.Where(m => m.Genre == Genre.Drama).ToList();
            //    case Genre.SiFi:
            //        return movies.Where(m => m.Genre == Genre.SiFi).ToList();
            //    default:
            //        return movies.Where(m => m.Genre == Genre.Other).ToList();
            //}
        }
    }
}
