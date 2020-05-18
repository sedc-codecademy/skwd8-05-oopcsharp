using CinemaApp.Domains;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaApp.Services
{
    public static class HelperService
    {
        public static void DisplayMoviesTitles(List<Movie> movies)
        {
            movies.ForEach(movie => Console.WriteLine(movie.Title));
        }

        public static int SelectCinemaByName(string userInput)
        {
            int number = 0;
            try
            {
                number = int.Parse(userInput);
                if (number == 1 || number == 2)
                {
                    return number;
                }
                else
                {
                    throw new Exception("The number you input must be eather 1 or 2");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("The number you input must be eather 1 or 2");
            }
            return number;
        }
    }
}
