using DomainModels;
using Services;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            LoginService loginService = new LoginService();
            loginService.LogIn("sedc.academy2", "4321"); // The first way of using LogIn

            UserModel stojance = new UserModel { UserName = "stojance", Password = "123456" };
            loginService.LogIn(stojance); // The second way of using LogIn


            //  Type  Name       Value
                Genre variable = Genre.Fantasy; // This works same as a declaring and initializing classes, except there is no constructor

            #region example for array of numbers
            int num1 = 2;
            int num2 = 7;
            int num3 = 21;
            int num4 = 863;
            int[] numbers = new int[] { num1, num2, num3, num4 };
            #endregion

            #region exactly the same as the example for array of numbers, but this is woth objects
            // We are using the Domain Model to represent few books
            BookModel book1 = new BookModel("some book 1", "dejan", Genre.Action, "english");
            BookModel book2 = new BookModel("some book 2", "vukashin", Genre.Action, "english");
            BookModel book3 = new BookModel("some book 3", "kristijan", Genre.Action, "english");
            BookModel book4 = new BookModel("some book 4", "andon", Genre.Action, "english");

            BookModel[] books = new BookModel[] { book1, book2, book3, book4 };
            #endregion

            // We are using the BookService which is working in combination with the Domain Model(BookModel) to do something with those few books that we represented earlier
            BookService bookService = new BookService();
            bookService.FindByName(books, "book 1");
            bookService.FindByAuthor(books, "andon");

            BookModel book5 = new BookModel("some book 5", "konstantin", Genre.Action, "english");
            books = bookService.AddBook(books, book5);

            Console.Read();
        }
    }
}
