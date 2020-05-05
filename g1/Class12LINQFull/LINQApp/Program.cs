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

            //foreach (var movie in partOfMovies)
            //{
            //    Console.WriteLine(movie.Title);
            //}

            // LAMBDA syntax in C#
            // (par => expression)

            //Console.ForegroundColor = ConsoleColor.Red;
            //partOfMovies.ForEach(movie => Console.WriteLine(movie.Title));
            //Console.ResetColor();
            #endregion


            #region Iterating Dictionary<TKey,TValue> with FOR using LINQ

            //var moviesCodes = new Dictionary<int, Movie>()
            //{
            //    {1,  new Movie(){ Title = "The Mountain II", Year = 2016, Rating = 8.9f, Duration = 135 } },
            //    {2,  new Movie(){ Title = "Seven Samurai", Year = 1954, Rating = 8.6f, Duration = 207 } },
            //    {3,  new Movie(){ Title = "Big Hero 6", Year = 2014, Rating = 7.8f, Duration = 102 } }
            //};

            //for (int i = 0; i < moviesCodes.Count; i++)
            //{
            //    KeyValuePair<int, Movie> movie = moviesCodes.ElementAt(i);
            //    Console.WriteLine($"Key: {movie.Key}, Value: {movie.Value.Title}");
            //}

            #endregion


            #region LINQ in Action - EXAMPLES

            List<Movie> movies = MoviesHelper.GetAllActionMovies();

            // 1. Find ALL movies with Title starting with 'T'
            //Lambda syntax
            var allMoviesTitleStartingWithTLambda = movies
                                                         .Where(movie => movie.Title.StartsWith('T')).ToList();

            //Sql query syntax
            var allMoviesTitleStartingWithTQuery = (from movie in movies 
                                                   where movie.Title.StartsWith('T')
                                                   select movie.Title).ToList();

            //foreach (var movie in allMoviesTitleStartingWithTLambda)
            //{
            //    Console.WriteLine(movie.Title);
            //}

            // Single
            // SingleOrDefault
            // First
            // FirstOrDefault
            // Last
            // LastOrDefault

            // 2. Find the FIRST Movie with Title starting with 'G' 
            //var firstMovieTitleWithG = movies.Single(movie => movie.Title.StartsWith('G'));
            //var firstMovieTitleWithG = movies.SingleOrDefault(movie => movie.Title.StartsWith('G'));
            //var firstMovieTitleWithG = movies.First(movie => movie.Title.StartsWith('G'));
            var firstMovieTitleWithGLambda = movies.FirstOrDefault(movie => movie.Title.StartsWith('G'));

            var firstMovieTitleWithGQuery = (from movie in movies
                                             where movie.Title.StartsWith('G')
                                             select movie.Title).FirstOrDefault();

            if (firstMovieTitleWithGLambda == null)
                Console.WriteLine("Movie starting with G not exists!!");

            //Console.WriteLine("The application continues....");

            //Console.WriteLine(firstMovieTitleWithG.Title);

            // 3. Find the LAST Movie with Title starting with 'G'

            var lastMovieStartingWithG = movies.Last(movie => movie.Title.StartsWith('G'));

            Console.WriteLine("Last movie starting with G: " + lastMovieStartingWithG.Title);

            // 4. Find ALL movies TITLES that plays for more than 2 hours

            // Miki da si naprai pukanki :)))))
            var allMoviesTitlesLongerThan2Hours = movies
                                            .Where(movie => movie.Duration > 120)
                                            .Select(movie => movie.Title)
                                            .ToList();

            allMoviesTitlesLongerThan2Hours.ForEach(title => Console.WriteLine(title));

            //foreach (var title in allMoviesTitlesLongerThan2Hours)
            //    Console.WriteLine(title);


            // 4 Extended. Find ALL movies TITLES AND RATINGS that plays for more than 2 hours
            // new { Something = movie.Title, NestoNesto = movie.Duration}
            var allMoviesTitlesRatingsLongerThan2Hours = movies
                                            .Where(movie => movie.Duration > 5000)
                                            .Where(movie => movie.Year < 2010)
                                            .Select(movie => new { Title = movie.Title, Rating = movie.Rating } )
                                            .ToList();

            var querySyntax = (from movie in movies
                               where movie.Duration > 120
                               where movie.Year < 2010
                               select movie);

            var querySyntaxOneLine = from movie in movies
                              where movie.Duration > 120 && movie.Year < 2010
                              select movie;

            if (allMoviesTitlesRatingsLongerThan2Hours.Count() > 0)
            {
                // code here if there are records from WHERE :)))
            }
            
            foreach (var item in allMoviesTitlesRatingsLongerThan2Hours)
            {
                Console.WriteLine(item.Title);
            }

            // 5. Find ALL movies TITLES produced before 2010 and ORDER by Title

            // 6. Find ALL movies TITLES produced after 2010, with Rating over 8.5 and ORDER by Title (Ascending/Descending Order)

            var allMoviesTitlesComplexConditionAsc = movies
                                                           .Where(movie => movie.Year > 2010)
                                                           .Where(movie => movie.Rating > 8.5)
                                                           .Select(movie => movie.Title)
                                                           //.OrderBy(title => title)
                                                           .OrderByDescending(title => title)
                                                           .ToList();

            // 7. What is the AVERAGE RANKING of ALL movies
            var averageRating = movies.Average(movie => movie.Rating);

            Console.WriteLine(averageRating);

            // 8. Find the BEST RANKING movie title (get only the TITLE and RANKING)

            var bestRankingofTheMovie = movies.Max(movie => movie.Rating);
            var bestTitle = movies
                .Single(movie => movie.Rating == bestRankingofTheMovie)
                .Title;
                //.Select(movie => movie.Title)
                //.Single();

            // 9. Find the WORST RANKING movie (get only the TITLE and DURATION)
            var worstMovieRanking = movies.Min(movie => movie.Rating);

            // 10. Get FIRST five movies
            var firstFive = movies.Take(5).ToList();

            // 11. Get LAST five movies
            var lastFive = movies.TakeLast(5).ToList();

            // 12. Get from the third one to the end of the list
            var customRange = movies.Skip(3).ToList();
            var customRangeNextFive = movies.Skip(3)
                                            .Take(5)
                                            .ToList();

            // Homework: 
            // part 1 - add additional 10 movies
            // part 2 - you will get another 10 requirements regarding the same LINQ methods :)))

            #endregion

            Console.ReadLine();
        }
    }
}