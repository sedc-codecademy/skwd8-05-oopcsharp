using DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class BookService
    {
        public void FindByName(BookModel[] books, string name)
        {
            foreach (BookModel book in books)
            {
                if (book.Name == name)
                    Console.WriteLine($"{book.Name} Found");
            }
        }

        public void FindByAuthor(BookModel[] books, string author)
        {
            foreach (BookModel book in books)
            {
                if (book.Author == author)
                    Console.WriteLine($"{book.Name} Found");
            }
        }

        public void FindByGenre(BookModel[] books, Genre genre)
        {
            foreach (BookModel book in books)
            {
                if (book.Genre == genre)
                    Console.WriteLine($"{book.Name} Found");
            }
        }

        public BookModel[] AddBook(BookModel[] books, BookModel book)
        {
            Array.Resize(ref books, books.Length + 1);
            books[books.Length - 1] = book;
            return books;
        }
    }
}
