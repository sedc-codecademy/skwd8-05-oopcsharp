using CinemaApp.Domains;
using System;
using CinemaApp.Domains.Enums;
using System.Collections.Generic;
using CinemaApp.Services;
using System.Linq;

namespace CinemaApp_Digital
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> cineplexMovies = MovieService.GenerateMoviesForCineplexx();
            Cinema cineplexx = new Cinema("Cineplexx");
            cineplexx.Movies = cineplexMovies;
            Cinema milenium = new Cinema("Milenium");
            List<Movie> mileniumMovies = MovieService.GenerateMoviesForMilenium();
            milenium.Movies = mileniumMovies;
            Console.WriteLine("Please enter 1 for cineplexx or 2 for Milenium");
            int userChoiseOfCinema = HelperService.SelectCinemaByName(Console.ReadLine());
            if(userChoiseOfCinema == 1)
            {
                Console.WriteLine("Welcome to Cineplexx");
                Console.WriteLine("Please enter 1 to see all the movies or 2 to filter by Genre");
                string userInput = Console.ReadLine();
                int result = 0;
                bool inputToNumber = int.TryParse(userInput, out result);
                if (inputToNumber && result == 1)
                {
                    HelperService.DisplayMoviesTitles(cineplexx.Movies);
                }
                else if(inputToNumber && result == 2)
                {
                    Console.WriteLine("Please enter a genre to filter through");
                    string userInputGenre = Console.ReadLine();
                    Genre genre;
                    switch (userInputGenre.ToLower())
                    {
                        case "action":
                            genre = Genre.Action;
                            break;
                        case "comedy":
                            genre = Genre.Comedy;
                            break;
                        case "horror":
                            genre = Genre.Horror;
                            break;
                        case "drama":
                            genre = Genre.Drama;
                            break;
                        case "sifi":
                            genre = Genre.SiFi;
                            break;
                        default:
                            genre = Genre.Other;
                            break;
                    }
                    List<Movie> fillteredMovies = MovieService.FilterByGenre(genre, cineplexx.Movies);
                    HelperService.DisplayMoviesTitles(fillteredMovies);
                    string favoriteMovie = Console.ReadLine();
                    Movie movie = fillteredMovies.SingleOrDefault(m => m.Title == favoriteMovie);
                    if (movie == null)
                    {
                        throw new Exception("Sorry that kind of movie does not exist");
                    }
                    Console.WriteLine(milenium.MoviePlaying(movie));
                }
                else
                {
                    throw new Exception();
                }
            }
            else if (userChoiseOfCinema == 2)
            {
                Console.WriteLine("Welcome to Milenium");
                Console.WriteLine("Please enter 1 to see all the movies or 2 to filter by Genre");
                string userInput = Console.ReadLine();
                int result = 0;
                bool inputToNumber = int.TryParse(userInput, out result);
                if (inputToNumber && result == 1)
                {
                    HelperService.DisplayMoviesTitles(cineplexx.Movies);
                }
                else if (inputToNumber && result == 2)
                {
                    Console.WriteLine("Please enter a genre to filter through");
                    string userInputGenre = Console.ReadLine();
                    Genre genre;
                    switch (userInputGenre.ToLower())
                    {
                        case "action":
                            genre = Genre.Action;
                            break;
                        case "comedy":
                            genre = Genre.Comedy;
                            break;
                        case "horror":
                            genre = Genre.Horror;
                            break;
                        case "drama":
                            genre = Genre.Drama;
                            break;
                        case "sifi":
                            genre = Genre.SiFi;
                            break;
                        default:
                            genre = Genre.Other;
                            break;
                    }
                    List<Movie> fillteredMovies = MovieService.FilterByGenre(genre, milenium.Movies);
                    HelperService.DisplayMoviesTitles(fillteredMovies);
                    string favoriteMovie = Console.ReadLine();
                    Movie movie = fillteredMovies.SingleOrDefault(m => m.Title == favoriteMovie);
                    if (movie == null)
                    {
                        throw new Exception("Sorry that kind of movie does not exist");
                    }
                    Console.WriteLine(milenium.MoviePlaying(movie));
                }
                else
                {
                    throw new Exception();
                }
            }
            else
            {
                throw new ApplicationException("You have entered a wrong input");
            }
        }
    }
}
