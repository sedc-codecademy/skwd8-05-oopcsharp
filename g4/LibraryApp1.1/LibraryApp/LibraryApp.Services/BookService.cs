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
                new EBook("Harry Potter and the goblet of fire", "Bob", Genres.Adventure, 200, "adventure/harrypotterseries", 50),
                new EBook("Spiderman", "John", Genres.ComicBook, 300, "comics/spideran", 30),
                new EBook("Star Wars", "Jack", Genres.Adventure, 400, "adventure/starwarsseries", 100),

                new HardCoverBook("Best book ever", "Kika", Genres.Adventure, 500, 10 , DateTime.Now),
                new HardCoverBook("How to be React master?", "Dejan", Genres.Adventure, 600, 3 , DateTime.Now),
                new HardCoverBook("Not so good book", "Petko", Genres.Novel, 1000, 30, DateTime.Now)
            };
        }

        public void PrintAllBooks()
        {
            if(Books.Length == 0)
            {
                Console.WriteLine("There are no books yet");
                return;
            }
            foreach (Book book in Books)
            {
                Console.WriteLine(book.BookInfo());
            }
        }
    }
}
