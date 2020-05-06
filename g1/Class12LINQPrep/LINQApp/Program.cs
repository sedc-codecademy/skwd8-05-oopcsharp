using LINQApp.Entities;
using LINQApp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQApp
{
    class Program
    {
        static void Main(string[] args)
        {

            #region FOREACH with LINQ

            var partOfMovies = new List<Movie>()
            {
                new Movie(){ Title = "The Mountain II", Year = 2016, Rating = 8.9f, Duration = 135 },
                new Movie(){ Title = "Seven Samurai", Year = 1954, Rating = 8.6f, Duration = 207 },
                new Movie(){ Title = "Big Hero 6", Year = 2014, Rating = 7.8f, Duration = 102 },
            };

            partOfMovies.ForEach(m => Console.WriteLine(m.Title));

            #endregion


            #region Iterating Dictionary<TKey,TValue> with FOR using LINQ

            var moviesCodes = new Dictionary<int, Movie>()
            {
                {1,  new Movie(){ Title = "The Mountain II", Year = 2016, Rating = 8.9f, Duration = 135 } },
                {2,  new Movie(){ Title = "Seven Samurai", Year = 1954, Rating = 8.6f, Duration = 207 } },
                {3,  new Movie(){ Title = "Big Hero 6", Year = 2014, Rating = 7.8f, Duration = 102 } }
            };

            for (int i = 0; i < moviesCodes.Count; i++)
            {
                KeyValuePair<int, Movie> movie = moviesCodes.ElementAt(i);
                Console.WriteLine($"Key: {movie.Key}, Value: {movie.Value.Title}");
            }

            #endregion


            #region LINQ in Action - EXAMPLES

            var movies = MoviesHelper.GetAllActionMovies();

            // 1. Find ALL movies with Title starting with 'T'

            // 2. Find the FIRST Movie with Title starting with 'G' 

            // 3. Find the LAST Movie with Title starting with 'G'

            // 4. Find ALL movies TITLES that plays for more than 2 hours

            // 5. Find ALL movies TITLES produced before 2010 and ORDER by Title

            // 6. Find ALL movies TITLES produced after 2010, with Rating over 8.5 and ORDER by Title (Descending Order)

            // 7. What is the AVERAGE RANKING of ALL movies

            // 8. Find the BEST RANKING movie (get only the TITLE and RANKING)

            // 9. Find the WORST RANKING movie (get only the TITLE and DURATION)

            // 10. Get FIRST five movies

            // 11. Get LAST five movies

            #endregion

            Console.ReadLine();
        }
    }
}