using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Models.Book
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public Genres Genre { get; set; }

        public int Pages { get; set; }

        public DateTime PublishDate { get; set; }

        public string BookInfo()
        {
            return $"{Title} - {Author} {Pages} pages ({Genre})";
        }
    }
}
