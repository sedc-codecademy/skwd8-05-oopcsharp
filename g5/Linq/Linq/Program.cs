using System;
using System.Collections.Generic;
using Models;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var movies = MoviesHelper.GetAllActionMovies();

            // 1. Find ALL movies with Title starting with 'T'
            List<Movie> moviesStartingWithT = movies.Where(movie => movie.Title.StartsWith("T")).ToList();
            PrintMovies(moviesStartingWithT);

            // 2. Find the FIRST Movie with Title starting with 'G' 
            //Movie task2 = movies.FirstOrDefault(movie => movie.Title[0] == 'G');
            Movie task2 = movies.FirstOrDefault(movie => movie.Title.StartsWith("G"));
            Console.WriteLine("---------------------------------");
            //if (task2 != null)
            //{
            //    Console.WriteLine(task2.GetInfo());
            //}
            //else
            //{
            //    Console.WriteLine("Nema takov film.");
            //}
            Console.WriteLine(task2 != null ? task2.GetInfo() : "Nema takov film vo listata");

            // 3. Find the LAST Movie with Title starting with 'G'
            Movie task3 = movies.LastOrDefault(movie => movie.Title.StartsWith("G"));
            Console.WriteLine("---------------------------------");
            Console.WriteLine(task3 != null ? task3.GetInfo() : "Nema takov film vo listata");

            // 4. Find ALL movies TITLES that plays for more than 2 hours
            List<string> movieNamesTwoHours = movies.Where(movie => movie.Duration > 120).Select(movie => movie.Title).ToList();
            Console.WriteLine("---------------------------------");
            movieNamesTwoHours.ForEach(movieName => Console.WriteLine(movieName));

            // 5. Find ALL movies TITLES produced before 2010 and ORDER by Title
            List<string> movieTitlesBefore2010 = movies.Where(movie => movie.Year < 2010)
                                                        .Select(movie => movie.Title)
                                                        .OrderBy(movie => movie)
                                                        .ToList();

            Console.WriteLine("---------------------------------");
            movieTitlesBefore2010.ForEach(movieName => Console.WriteLine(movieName));

            // 6. Find ALL movies TITLES produced after and in 2010, with Rating over 8.5 and ORDER by Title (Descending Order)

            List<string> producedAfter2010 = movies.Where(movie => movie.Year >= 2010 
                                                                   && movie.Rating > 8.5)
                                                    .Select(movie => movie.Title)
                                                    .OrderByDescending(movie => movie)
                                                    .ToList();

            Console.WriteLine("---------------------------------");
            PrintMovies(producedAfter2010);

            // 7. What is the AVERAGE RANKING of ALL movies
            //double averageRanking = movies.Select(movie => movie.Rating).Average();
            double averageRanking = movies.Average(movie => movie.Rating);
            Console.WriteLine("---------------------------------");
            Console.WriteLine(averageRanking);

            // 8. Find the BEST RANKING movie (get only the TITLE and RANKING)
            //var task8 = movies.OrderByDescending(movie => movie.Rating).Select(movie => new { movie.Title, movie.Rating }).FirstOrDefault();

            //KeyValuePair<float, string> bestRankingMovie = movies.OrderByDescending(movie => movie.Rating)
            //    .Select(movie => new KeyValuePair<float, string>(movie.Rating, movie.Title)).FirstOrDefault();

            MovieSimpleModel bestRankingMovie = movies.OrderByDescending(movie => movie.Rating)
                .Select(movie => new MovieSimpleModel(movie.Title, movie.Rating)).FirstOrDefault();
            if (bestRankingMovie != null)
            {
                Console.WriteLine($"Best movie: {bestRankingMovie.Title} {bestRankingMovie.Rating}");
            }
            else
            {
                Console.WriteLine("Nema film vo listata");
            }

            // 9. Find the WORST RANKING movie (get only the TITLE and DURATION)
            KeyValuePair<string, int> task9 = movies.OrderBy(movie => movie.Rating)
                .Select(movie => new KeyValuePair<string, int>(movie.Title, movie.Duration))
                .FirstOrDefault();

            if (!string.IsNullOrEmpty(task9.Key) && task9.Value != 0)
            {
                Console.WriteLine($"Worst movie: {task9.Key} {task9.Value}");
            }
            else
            {
                Console.WriteLine("Nema film vo listata");
            }

            // 10. Get FIRST five movies
            List<Movie> firstFive = movies.Take(5).ToList();
            PrintMovies(firstFive);

            // 11. Get LAST five movies
            List<Movie> lastFive = movies.TakeLast(5).ToList();
            PrintMovies(lastFive);
        }

        static void PrintMovies(List<Movie> movies)
        {
            Console.WriteLine("----------------------------------------------");
            movies.ForEach(movie => Console.WriteLine(movie.GetInfo()));
        }

        static void PrintMovies(List<string> movies)
        {
            Console.WriteLine("----------------------------------------------");
            movies.ForEach(Console.WriteLine);
        }
    }
}
