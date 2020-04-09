using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels
{
    public class BookModel
    {
        public BookModel() // Empty
        {
            Name = "";
            Author = "";
            Genre = Genre.Comedy;
            Languange = "english";
        }
        public BookModel(string name, string author, Genre genre, string language) // Full
        {
            Name = name;
            Author = author;
            Genre = genre;
            Languange = language;
        }
        public string Name { get; set; }
        public string Author { get; set; }
        public Genre Genre { get; set; }
        public string Languange { get; set; }
    }
}
