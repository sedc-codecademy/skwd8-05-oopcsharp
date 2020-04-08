using SEDC.DomainModels;
using System;

namespace SEDC.Class06_Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book() { Title = "Lord of the rings", Author = "Ivo", NumberOfPages = 1000, YearOfPublish = new DateTime(2001, 10, 2)};
            User user = new User() { FirstName = "Martin", LastName = "Panovski", Age = 26, Username = "martin@sedc.com", Password = "111" };


            
            Console.ReadLine();
        }
    }
}
