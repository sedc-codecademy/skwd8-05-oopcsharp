using PreparationSolution.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PreparationSolution.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public double Rating { get; set; }
        public int Year { get; set; }
        public int Duration { get; set; }
        public Genre Genre { get; set; }
    }
}
