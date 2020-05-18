using SEDC.VideoRental.Data.Database;
using SEDC.VideoRental.Data.Models;
using SEDC.VideoRental.Services.Helpers;
using SEDC.VideoRental.Services.Menus;
using System;
using System.Collections.Generic;
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
            bool isFinished = false;
            while (!isFinished)
            {
                Screen.OrderingMenu();
                var selection = InputParser.ToInteger(0, 9);
                switch (selection)
                {
                    case 1:
                        var movies = _movieRepository.GetAllMovies();
                        PrintMoviesInfo(movies);
                        break;
                    case 2:
                        var orderedMoviesByGenre = _movieRepository.OrderByGenre();
                        PrintMoviesInfo(orderedMoviesByGenre);
                        break;
                    case 3:
                        // Get videos by genre;
                        break;
                    case 4:
                        var orderedMoviesByReleaseDate = _movieRepository.OrderByReleaseDate();
                        PrintMoviesInfo(orderedMoviesByReleaseDate);
                        break;
                    case 5:
                        // Get movies by year of release
                        break;
                    case 6:
                        var orderedMoviesByAvailability = _movieRepository.OrderByAvailability();
                        PrintMoviesInfo(orderedMoviesByAvailability);
                        break;
                    case 7:
                        // Get available videos
                        break;
                    case 8:
                        // Search videos by title
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
