using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.LibraryApp.Domain
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Pages { get; set; }
        public DateTime PublishDate { get; set; }

        public string BookInfo()
        {
            return $"{Title} - {Author} {Pages} pages ({Genre})";
        }
    }
}
