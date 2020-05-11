using SEDC.Class10.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SEDC.Class10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> listOfMovies = new List<Movie>();
            for (int i = 0; i < 3; i++)
            {
                var movie12 = CreateNewMovie1();
                if(movie12 != null)
                {
                    listOfMovies.Add(movie12);
                    Console.WriteLine(movie12.Name);
                }
                //listOfMovies.Add(CreateNewMovie());
            }

            foreach (var movie in listOfMovies)
            {
                Console.WriteLine(movie.Name);
            }


            Console.ReadLine();
        }

        public static Movie CreateNewMovie()
        {
            Movie movie = null;
            bool isCreated = false;

            while (!isCreated)
            {
                Console.Write("Enter movie title: ");
                var name = Console.ReadLine();

                Console.Write("Enter genre: ");
                var genre = Console.ReadLine();

                Console.Write("Enter rating: ");
                var rating = int.Parse(Console.ReadLine());
                
                // One option

                //if(rating >= 1 && rating <= 5)
                //{
                //    movie = new Movie(rating, name, genre);
                //    isCreated = true;
                //}
                //else
                //{
                //    Console.WriteLine("Rating is not valid please enter rating betwen 1 and 5");
                //    isCreated = false;
                //}
                
                try
                {
                    movie = new Movie(rating, name, genre);
                    isCreated = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Rating is not valid please enter rating betwen 1 and 5");
                    Debug.WriteLine(DateTime.Now);
                    Debug.WriteLine(ex.Message);
                    Debug.WriteLine(ex.StackTrace);
                    isCreated = false;
                }
            }
            return movie;
        }

        public static Movie CreateNewMovie1()
        {
            Console.Write("Enter movie title: ");
            var name = Console.ReadLine();

            Console.Write("Enter genre: ");
            var genre = Console.ReadLine();

            Console.Write("Enter rating: ");
            var rating = int.Parse(Console.ReadLine());
            try
            {
                return new Movie(rating, name, genre);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Rating is not valid please enter rating betwen 1 and 5");
                Debug.WriteLine(DateTime.Now);
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
                return null;
            }
        }
    }
}
