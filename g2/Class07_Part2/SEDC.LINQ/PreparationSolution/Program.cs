using PreparationSolution.Enums;
using PreparationSolution.Helpers;
using PreparationSolution.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PreparationSolution
{
    class Program
    {
        public static void PrintAllElements(List<Movie> movies)
        {
            foreach (var movie in movies)
            {
                Console.WriteLine(movie.Title); ;
            }
        }

        static void Main(string[] args)
        {
            List<Movie> movies = MoviesHelper.GetAllMovies();




            #region LINQ in Action - EXAMPLES


            // 1. Find ALL movies with Title starting with 'T'
            
            //Regular way
            foreach (var movie in movies)
            {
                if (movie.Title.StartsWith('T'))
                {
                    Console.WriteLine("Title starts with T: " + movie.Title);
                }
            }
            Console.WriteLine("Where() =============================================");


            //LINQ syntax: Using Where()

            List<Movie> moviesStartsWithT = movies.Where(x => x.Title.StartsWith('T')).ToList();
            foreach (var movie in moviesStartsWithT)
            {
                Console.WriteLine(movie.Title);
            }

            Console.WriteLine("First() =======================================");



            // 2. Find the FIRST Movie with Title starting with 'G' 

            //Throws an exception because there is no movie that its Title starts with 'G'

            //Movie movieStartsWithG = movies.Where(x => x.Title.StartsWith('G')).First();
            //Console.WriteLine(movieStartsWithG.Title);


            Console.WriteLine("FirstOrDefault() ===============================");
            Movie movieStartsWithG = movies.Where(x => x.Title.StartsWith('G')).FirstOrDefault();

            //Needed to be handled with null check, because the default value for Movie is null
            if(movieStartsWithG != null)
            {
                Console.WriteLine(movieStartsWithG.Title);
            }
            else
            {
                Console.WriteLine("There is no such movie that its title starts with letter G");
            }



            // 3. Find the LAST Movie with Title starting with 'G'

            Console.WriteLine("Last() =============================================");
            //Movie lastStartsWithG = movies.Where(x => x.Title.StartsWith('G')).Last();
            //Console.WriteLine(lastStartsWithG.Title);


            Console.WriteLine("LastOrDefault() =============================================");
            Movie lastStartsWithG = movies.Where(x => x.Title.StartsWith('G')).LastOrDefault();

            Console.WriteLine(lastStartsWithG != null ? lastStartsWithG.Title : "No such movie");



            // 4. Find the FIRST and LAST movie with Raiting of 7.0

            Console.WriteLine("First() and Last() only =========================================");
            Movie raitingOfSeven = movies.First(x => x.Rating == 7);
            Console.WriteLine(raitingOfSeven != null ? raitingOfSeven.Title : "No movie with raiting of 7");

            Movie raitingOfSevenLast = movies.Last(x => x.Rating == 7);
            Console.WriteLine(raitingOfSeven != null ? raitingOfSeven.Title : "No movie with raiting of 7");



            // 5. Find the only (single) movie that its year is 2010

            Console.WriteLine("Single() and SingleOrDefault() only =========================================");
            //Movie onlyMovie = movies.Single(x => x.Year == 2010);
            //Console.WriteLine(onlyMovie != null ? onlyMovie.Title : "There are no movies of 2010 year, or there are more like that!");

            Movie onlyMovie = movies.SingleOrDefault(x => x.Year == 1995);
            Console.WriteLine(onlyMovie != null ? onlyMovie.Title : "There are no movies of 2010 year, or there are more like that!");



            // 4. Find ALL movies TITLES that plays for more than 2 hours

            Console.WriteLine("=========================================");
            List<Movie> longerThanTwoHours = movies.Where(x => x.Duration > 120).ToList();


            longerThanTwoHours.ForEach(x => Console.WriteLine(x.Title));
            //PrintAllElements(longerThanTwoHours);



            // 4.Extended: Find ALL movies TITLES that plays for more than 2 hours
            Console.WriteLine("Select() =========================================");
            List<string> movieTitlesLongerThanTwoHours = movies
                                            .Where(x => x.Duration > 120)
                                            .Select(x => x.Title)
                                            .ToList();

            movieTitlesLongerThanTwoHours.ForEach(x => Console.WriteLine(x));


            var titleAndDurationOfLongerThanTwoHours = movies
                                                .Where(x => x.Duration > 120)
                                                .Select(x => new { Title = x.Title, Duration = x.Duration })
                                                .ToList();

            titleAndDurationOfLongerThanTwoHours.ForEach(x => Console.WriteLine($"Title {x.Title} | Duration: {x.Duration}"));



            // 5. Find ALL movies TITLES produced before 2010 and ORDER by Title

            Console.WriteLine("OrderBy and OrderByDescending =====================================================");
            List<string> moviesBefore2010OrderdByTitle = movies
                                             .Where(movie => movie.Year < 2010)
                                             .Select(movie => movie.Title)
                                             //.OrderBy(title => title)
                                             .OrderByDescending(title => title)
                                             .ToList();

            moviesBefore2010OrderdByTitle.ForEach(title => Console.WriteLine(title));


            // 6. Find ALL movies TITLES produced after 2010, with Rating over 8.5 and ORDER by Title (Descending Order)
            Console.WriteLine("Complex query ===============================================");
            List<string> moviesAfter2010 = movies.Where(x => x.Year > 2010 && x.Rating > 8.5)
                                                 //.Where(x => x.Rating > 8.5)
                                                 .Select(x => x.Title)
                                                 .OrderByDescending(title => title)
                                                 .ToList();

            moviesAfter2010.ForEach(title => Console.WriteLine(title));



            // 7. What is the AVERAGE RANKING of ALL movies
            Console.WriteLine("Operation methods: Average() | Sum() ===============================================");

            double averageRatingOfMovies = movies.Average(x => x.Rating);
            Console.WriteLine(averageRatingOfMovies);

            double totalMoviesRating = movies.Sum(x => x.Rating);
            Console.WriteLine("Total raiting of movies " + totalMoviesRating);



            // 8. Find the BEST RANKING movie (get only the TITLE and RANKING)

            Console.WriteLine("Max() ===============================================");

            double bestRank = movies.Max(x => x.Rating);

            var bestRankingMovie = movies
                                    .Where(movie => movie.Rating == bestRank)
                                    .Select(x => new { Title = x.Title, Raiting = x.Rating })
                                    .SingleOrDefault();
            Console.WriteLine($"Title: {bestRankingMovie.Title} | Raiting: {bestRankingMovie.Raiting}");



            // 9. Find the WORST RANKING movie (get only the TITLE and DURATION)

            Console.WriteLine("Max() ===============================================");

            double worstRanking = movies.Min(x => x.Rating);

            var worstRankginMovie = movies
                                      .Where(movie => movie.Rating == worstRanking)
                                      .Select(x => new { Title = x.Title, Duration = x.Duration })
                                      .SingleOrDefault();

            Console.WriteLine($"Title: {worstRankginMovie.Title} | Raiting: {worstRankginMovie.Duration}");



            // 10. Get FIRST five movies

            Console.WriteLine("Take() ===============================================");

            List<Movie> firstFiveMovies = movies.Take(5).ToList();
            firstFiveMovies.ForEach(x => Console.WriteLine("First five movies " + x.Title));



            // 11. Get LAST five movies

            Console.WriteLine("TakeLast() ===============================================");

            List<Movie> lastFiveMovies = movies.TakeLast(5).ToList();
            lastFiveMovies.ForEach(x => Console.WriteLine("Last five " + x.Title));



            // 12. Get from the third to the end of the list

            List<Movie> customRange = movies.Skip(5)
                                            .Take(6)
                                            .ToList();
            customRange.ForEach(x => Console.WriteLine("Second page " + x.Title));



            // =============================== BONUS ============================
            // ============================ BEFORE LINQ ============================
            // Typical SQL syntax

            //select Title 
            //from Movies
            //where Raiting > 8.5
            var moviesWithHighRaiting = (from movie in movies
                                         where movie.Rating > 8.5
                                         select movie.Title).ToList();


         #endregion


            Console.ReadLine();
        }
    }
}
