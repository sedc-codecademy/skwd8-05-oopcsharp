using CinemaApp.Domains;
using CinemaApp.Domains.Enums;
using CinemaApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CinemaApp.Main
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            List<Movie> cineplexxMovies = MoviesService.GenerateMoviesForCineplexx();
            Cinema cineplexx = new Cinema("Cineplexx");
            List<Movie> mileniumMovies = MoviesService.GenerateMoviesForMilenium();
            Cinema milenium = new Cinema("Milenium");
            cineplexx.Movies = cineplexxMovies;
            milenium.Movies = mileniumMovies;

            //Console.WriteLine($"These are the movies showing in {cineplexx.Name}: ");
            //HelperService.DisplayMoviesTitles(cineplexxMovies);

            Console.WriteLine("Please enter 1 for Cineplexx, enter 2 for Milenium!");
            int userChoiceofCinema;
            userChoiceofCinema = HelperService.SelectCinema(Console.ReadLine());

            //check whether user typed 1,2 or 0(zero) // refactor with switch (case), transfer the code to a service method
            if (userChoiceofCinema == 1) // Cineplexx
            {
                Console.WriteLine("Welcome to Cineplexx!");
                Console.WriteLine("Please enter 1 to see all the movies showing here. Or enter 2 to filter them by Genre!");
                string userInput = Console.ReadLine();
                int result = 0;
                bool inputToNumber = int.TryParse(userInput, out result); // The method returns boolean that shows whether the parsing was successful. If successful the result is the variable result.
                if(inputToNumber && result == 1) // check whether the parsing was successful and the number typed is 1
                {
                    Console.WriteLine($"These are the movies showing in {cineplexx.Name}: ");
                    HelperService.DisplayMoviesTitles(cineplexx.Movies);
                    Console.WriteLine("Please choose one of the movies in the list.");
                    string favMovie = Console.ReadLine();
                    Movie movie = cineplexxMovies.SingleOrDefault(m => m.Title == favMovie);
                    if (movie == null)
                        throw new Exception("This movie is not showing in cineplexx");
                    Console.WriteLine(cineplexx.MoviePlaying(movie));
                }
                else if(inputToNumber && result == 2) // check whether the parsing was successful and the number typed is 2
                {
                    //1. User should be asked for a favorite Genre.
                    //2. List all movies from that Genre
                    //3. User should choose one of the movies shown
                    Console.WriteLine("Please enter a genre to filter movies in this cinema.");
                    string userInputG = Console.ReadLine();
                    Genre genre;
                    switch (userInputG.ToLower())
                    { //Comedy,Horror,Action,Drama,SciFi,Other
                        case "action":
                            genre = Genre.Action;
                            break;
                        case "horror":
                            genre = Genre.Horror;
                            break;
                        case "comedy":
                            genre = Genre.Comedy;
                            break;
                        case "drama":
                            genre = Genre.Drama;
                            break;
                        case "scifi":
                            genre = Genre.SciFi;
                            break;
                        default:
                            genre = Genre.Other;
                            break;
                    }
                    List<Movie> filteredMovies = MoviesService.FilterByGenre(cineplexx.Movies, genre);
                    Console.WriteLine($"These are the movies showing in Cineplexx of the genre {genre}");
                    HelperService.DisplayMoviesTitles(filteredMovies);
                    Console.WriteLine("Please choose one of the movies in the list.");
                    string favMovie = Console.ReadLine();
                    Movie movie = cineplexxMovies.SingleOrDefault(m => m.Title == favMovie);
                    if (movie == null)
                        throw new Exception("This movie is not showing in cineplexx");
                    Console.WriteLine(cineplexx.MoviePlaying(movie));
                }
                else
                {
                    throw new Exception("You should have entered a value 1 or 2 to view or filter movies showing in Cineplexx!!!");
                }
            }
            else if (userChoiceofCinema == 2) //Milenium
            {
                // For Homework
            }
            else {
                throw new ApplicationException("You have entered a wrong input!");
            }

            Console.WriteLine("Enter any character and press ENTER to quit executing of the program:");
            Console.ReadLine();
        }
    }
}
