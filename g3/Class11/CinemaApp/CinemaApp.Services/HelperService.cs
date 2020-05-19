using CinemaApp.Domains;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace CinemaApp.Services
{
    public static class HelperService
    {
        public static void DisplayMoviesTitles(List<Movie> movies)
        {
            movies.ForEach(movie => Console.WriteLine(movie.Title));
        }

        public static int SelectCinema(string userInput)
        {
            int number = 0;
            try
            {
                number = int.Parse(userInput);
                if(number == 1 || number == 2)
                {
                    return number;
                }
                else
                {
                    throw new Exception("The number must be either 1 or 2!!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("The inputmust be number and be either 1 or 2!!!");
            }
            return number;
        }
    }
}
