using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaApp.Domains
{
    public class Cinema
    {
        public Cinema(string name)
        {
            Name = name;
            Halls = new List<int>();
            Movies = new List<Movie>();
        }

        public string Name { get; set; }
        public List<int> Halls { get; set; }
        public List<Movie> Movies { get; set; }

        public string MoviePlaying(Movie movie)
        {
            return $"The movie {movie.Title} is playing at the moment";
        }
    }
}
