using SEDC.VideoRental.Data.Database;
using SEDC.VideoRental.Data.Models;
using SEDC.VideoRental.Services.Helpers;
using SEDC.VideoRental.Services.Loaders;
using SEDC.VideoRental.Services.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

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
            string errorMessage = string.Empty;
            var movies = _movieRepository.GetAllMovies();

            bool isFinished = false;
            while (!isFinished)
            {
                Screen.ClearScreen();
                Screen.ErrorMessage(errorMessage);
                if (movies.Count != 0)
                {
                    PrintMoviesInfo(movies);
                }
                else
                {
                    Console.WriteLine("No videos available with that filtering options");
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
                        try
                        {
                            RentVideo(user);
                        }
                        catch (Exception ex)
                        {
                            errorMessage = ex.Message;
                        }
                        break;
                    case 0:
                        isFinished = !isFinished;
                        break;
                }
            }
        }

        private void RentVideo(User user)
        {
            Console.Write("Enter movie id: ");
            var movieId = InputParser.ToInteger(
                _movieRepository.GetAllMovies().Min(_movie => _movie.Id),
                _movieRepository.GetAllMovies().Max(_movie => _movie.Id)
                );

            var movie = _movieRepository.GetMovieById(movieId);
            if (movie != null)
            {
                if (!movie.IsAvailable)
                {
                    throw new Exception($"Movie {movie.Title} is not available at the moment");
                }
                Console.WriteLine($"Are you sure you want to rent {movie.Title}? y/n");
                bool confirm = InputParser.ToConfirm();
                if (!confirm)
                {
                    return;
                }

                Console.WriteLine("Renting movie please wait...");
                LoadingHelpers.Spiner();
                movie.Quantity -= 1;
                if(movie.Quantity == 0)
                {
                    movie.IsAvailable = !movie.IsAvailable;
                }
                user.RentedMovies.Add(new RentalInfo(movie));
                Console.WriteLine("Successfuly rented movie");
                Thread.Sleep(2000);
            }
            else
            {
                throw new Exception($"No movie was found with {movieId} id");
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

        public void ViewRentedVideos(User user)
        {
            string errorMessage = string.Empty;
            var rentals = user.RentedMovies;
            bool isFinished = false;
            while (!isFinished)
            {
                try
                {
                    Screen.ClearScreen();
                    Screen.ErrorMessage(errorMessage);
                    if(rentals.Count != 0)
                    {
                        var movies = rentals.Select(_rental => _rental.Movie).ToList();
                        PrintMoviesInfo(movies);
                    }
                    else
                    {
                        throw new Exception("You have not rented any videos");
                    }
                    Screen.RentedMenu();
                    int selection = InputParser.ToInteger(0, 2);
                    switch (selection)
                    {
                        case 1:
                            rentals = user.RentedMovies;
                            break;
                        case 2:
                            ReturnMovie(user);
                            break;
                        case 0:
                            isFinished = !isFinished;
                            break;
                    }
                }
                catch (Exception ex)
                {
                    errorMessage = ex.Message;
                }
            }
        }

        private void ReturnMovie(User user)
        {
            if(user.RentedMovies.Count == 0)
            {
                throw new Exception("You do not have any rented videos.");
            }

            Console.WriteLine("Enter movie id in order to return a video");
            var movieId = InputParser.ToInteger(1, int.MaxValue);

            var rental = user.RentedMovies.FirstOrDefault(_rental => _rental.Movie.Id == movieId);
            LoadingHelpers.ShowSimplePercentage();
            if(rental != null)
            {
                rental.DateReturned = DateTime.Now;
                var movie = _movieRepository.GetMovieById(movieId);
                if(movie.Quantity == 0)
                {
                    movie.IsAvailable = !movie.IsAvailable;
                }
                movie.Quantity += 1;

                user.RentedMovies.Remove(rental);
                user.RentedMoviesHistory.Add(rental);

                Console.WriteLine("Successfuly returned.");
                Thread.Sleep(2000);
                return;
            }

            throw new Exception("You do not have that movie rented. Please enter valid movie id");
        }

        // to be implemented in later stage
        private void PrintRentedInfo(List<RentalInfo> rentals)
        {

        }
    }
}
