using System;

namespace ClassExercise
{
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public void GetPersonStats()
        {
            Console.WriteLine($"I am {FirstName} {LastName} and I'm {Age}.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human ivan = new Human();

            Console.WriteLine("Enter firstname");
            ivan.FirstName = Console.ReadLine();

            Console.WriteLine("Enter lastname");
            ivan.LastName = Console.ReadLine();

            Console.WriteLine("Enter age");
            ivan.Age = int.Parse(Console.ReadLine());

            ivan.GetPersonStats();

            Human kristina = new Human()
            {
                FirstName = "Kristina",
                LastName = "Spasevska",
                Age = 33
            };

            //kristina.GetPersonStats();
            Console.ReadLine();
        }
    }
}
