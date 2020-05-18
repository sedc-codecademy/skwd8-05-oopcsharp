using SEDC.VideoRental.Data.Database;
using SEDC.VideoRental.Data.Models;
using SEDC.VideoRental.Services.Helpers;
using SEDC.VideoRental.Services.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.VideoRental.Services.Services
{
    public class MovieService
    {
        private MovieRepository _movieRepository;

        public MovieService()
        {
            _movieRepository = new MovieRepository();
        }

        public void ViewMovieList(User user)
        {
            var movies = new List<Movie>();

            bool isFinished = false;
            while (!isFinished)
            {
                if (movies.Count != 0)
                {
                    PrintMoviesInfo(movies);
                }
                Screen.OrderingMenu();
                var selection = InputParser.ToInteger(0, 9);
                switch (selection)
                {
                    case 1:
                        movies = _movieRepository.GetAllMovies();
                        break;
                    case 2:
                        movies = _movieRepository.OrderByGenre();
                        break;
                    case 3:
                        var genre = InputParser.ToGenre();
                        movies = _movieRepository.GetByGenre(genre);
                        break;
                    case 4:
                        movies = _movieRepository.OrderByReleaseDate();
                        break;
                    case 5:
                        Console.Write("Enter year: ");
                        var year = InputParser.ToInteger(
                            _movieRepository.GetAllMovies().Min(_movie => _movie.ReleaseDate.Year),
                            DateTime.Now.Year - 1
                            );
                        movies = _movieRepository.GetByYear(year);
                        break;
                    case 6:
                        movies = _movieRepository.OrderByAvailability();
                        break;
                    case 7:
                        movies = _movieRepository.GetAvailableMovies();
                        break;
                    case 8:
                        Console.Write("Enter search phrase: ");
                        string titlePart = Console.ReadLine();
                        movies = _movieRepository.SearchMoviesByTitle(titlePart);
                        break;
                    case 9:
                        // Rent a video
                        break;
                    case 0:
                        isFinished = !isFinished;
                        break;
                }
            }
        }

        private void PrintMoviesInfo(List<Movie> movies)
        {
            foreach (var movie in movies)
            {
                string availablity = movie.IsAvailable ? "Yes" : "No";
                Console.WriteLine(
                    string.Format("Rent id: {0} Title: {1} Release Date: {2} Genre: {3} Available {4} Quatity: {5}",
                    movie.Id, movie.Title, movie.ReleaseDate.ToString("MMMM dd yyyy"), 
                    movie.Genre, availablity, movie.Quantity)
                    );
            }
        }
    }
}
