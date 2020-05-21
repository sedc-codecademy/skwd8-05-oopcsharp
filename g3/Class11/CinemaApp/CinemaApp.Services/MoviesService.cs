using CinemaApp.Domains;
using CinemaApp.Domains.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemaApp.Services
{
    // We will provide 10 movies per cinema to put in the cinema movies list
    public class MoviesService
    {
        public static List<Movie> GenerateMoviesForCineplexx()
        {
            Movie movie1 = new Movie("Scary Movie", Genre.Comedy, 4);
            Movie movie2 = new Movie("American Pie", Genre.Comedy, 4);
            Movie movie3 = new Movie("Saw", Genre.Horror, 3);
            Movie movie4 = new Movie("The Shining", Genre.Horror, 4);
            Movie movie5 = new Movie("Rambo", Genre.Action, 1);
            Movie movie6 = new Movie("The Terminator", Genre.Action, 2);
            Movie movie7 = new Movie("Forrest Gump", Genre.Drama, 5);
            Movie movie8 = new Movie("12 Angry Men", Genre.Drama, 5);
            Movie movie9 = new Movie("Passengers", Genre.SciFi, 4);
            Movie movie10 = new Movie("Interstellar", Genre.SciFi, 4);

            return new List<Movie> { movie1,movie2,movie3, movie4, movie5, movie6, movie7, movie8, movie9, movie10};
        }
        public static List<Movie> GenerateMoviesForMilenium()
        {
            Movie movie11 = new Movie("Airplane", Genre.Comedy, 4);
            Movie movie12 = new Movie("Johnny English", Genre.Comedy, 4);
            Movie movie13 = new Movie("The Ring", Genre.Horror, 4);
            Movie movie14 = new Movie("Sinister", Genre.Horror, 4);
            Movie movie15 = new Movie("RoboCop", Genre.Action, 4);
            Movie movie16 = new Movie("Judge Dredd", Genre.Action, 4);
            Movie movie17 = new Movie("The Social Network", Genre.Drama, 4);
            Movie movie18 = new Movie("The Shawshank Redemption", Genre.Drama, 4);
            Movie movie19 = new Movie("Inception", Genre.SciFi, 4);
            Movie movie20 = new Movie("Avatar", Genre.SciFi, 4);

            return new List<Movie> { movie11, movie12, movie13, movie14, movie15, movie16, movie17, movie18, movie19, movie20 };
        }

        public static List<Movie> FilterByGenre(List<Movie> movies, Genre genre)
        {
            //The declarative way
            return movies.Where(m => m.Genre == genre).ToList();

            // // The imperative way
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
            //    case Genre.SciFi:
            //        return movies.Where(m => m.Genre == Genre.SciFi).ToList();
            //    default:
            //        return movies.Where(m => m.Genre == Genre.Other).ToList();
            //}

            //throw new NotImplementedException();
        }

        public static List<Movie> GetMoviesLargerThen(short rating, List<Cinema> cinemas)
        {
            List<Movie> resultMovies = new List<Movie>();

            cinemas.ForEach(c => resultMovies.AddRange(
                //c.Movies.Where(m => m.Rating > rating).ToList()
                FilterMoviesBy(rating, c)
            ));

            return resultMovies;
        }

        public static List<Movie> GetMoviesLargerThen(short rating, Cinema cinema)
        {
            return FilterMoviesBy(rating, cinema);
        }

        private static List<Movie> FilterMoviesBy(short rating, Cinema cinema)
        {
            return cinema.Movies.Where(m => m.Rating > rating).ToList();
        }
    }
}
