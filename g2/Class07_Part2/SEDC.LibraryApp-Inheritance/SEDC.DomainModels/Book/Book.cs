using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.DomainModels.Book
{
    public class Book
    {
        public string Title { get; set; }
        //TODO: Implement author as separate class
        public string Author { get; set; }
        public Genre Genre { get; set; }
        public int Pages { get; set; }
        public DateTime PublishDate { get; set; }

        public Book(string title, string author, Genre genre, int pages)
        {
            this.Title = title;
            this.Author = author;
            this.Genre = genre;
            this.Pages = pages;
        }

        public Book()
        {
        }

        public virtual string BookInfo()
        {
            return $"{Title} - {Author} {Pages} pages ({Genre})";
        }
    }
}
