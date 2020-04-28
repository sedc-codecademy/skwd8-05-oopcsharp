using LibraryApp.Models.Book;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Services
{
    public class BookService
    {
        public Book[] Books { get; set; }

        public BookService()
        {
            Books = new Book[]
            {
                new Book()
                {
                    Author = "J.K.Rowling",
                    Genre = Genres.Novel,
                    Pages = 200,
                    Title = "Harry Potter"
                },
                new Book()
                {
                    Author = "Gail Simone",
                    Genre = Genres.ComicBook,
                    Pages = 150,
                    Title = "Birds of Pray"
                },
                new Book()
                {
                    Author = "Terry Brooks",
                    Genre = Genres.Adventure,
                    Pages = 300,
                    Title = "Star Wars"
                }
            };
        }

        public void PrintAllBooks()
        {
            foreach (Book book in Books)
            {
                Console.WriteLine(book.BookInfo());
            }
        }
    }
}
