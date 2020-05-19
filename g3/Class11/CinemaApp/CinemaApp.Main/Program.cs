using CinemaApp.Domains;
using CinemaApp.Services;
using System;
using System.Collections.Generic;

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



            Console.WriteLine("Enter any character and press ENTER to quit executing of the program:");
            Console.ReadLine();
        }
    }
}
