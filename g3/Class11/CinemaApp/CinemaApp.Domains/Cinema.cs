using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaApp.Domains
{
    // Make a class Cinema. Cinema must have: Name, Halls , ListOfMovies
    // Cinema should have method MoviePlaying  that will have a parameter ‘movie’ and then print out in the console “Watching Movie.Title”
    // We will provide 10 movies per cinema to put in the cinema movies list
    public class Cinema
    {
        public string Name { get; set; }
        public List<int> Halls { get; set; }
        public List<Movie> Movies { get; set; }
        public Cinema (string name) //, List<int> halls, List<Movie> movies
        {
            Name = name;
            Halls = new List<int>();
            Movies = new List<Movie>();
        }
        public string MoviePlaying(Movie movie)
        {
            return $"Watching: {movie.Title}";
        }
    }
}
