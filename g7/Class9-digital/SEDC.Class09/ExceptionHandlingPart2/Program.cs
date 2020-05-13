using ExceptionHandlingPart2.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExceptionHandlingPart2
{
    class Animal
    {
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>
            {
                new Animal { Name = "Dejan" },
                new Animal { Name = "Damjan" },
                new Animal { Name = "Dusica" },
                new Animal { Name = "Marko" }
            };

            Console.WriteLine("Enter a number between 10-20");
            string userInput = Console.ReadLine();
            int number = -1;

            try
            {
                number = int.Parse(userInput); // This line could potentially throw FormatException

                if (number >= 10 && number <= 20) // This logics checks if the valid number that the user entered is between 10-20, if it's not it will throw the Damjan exception
                {
                    Console.WriteLine("The number you entered is between 10-20");
                }
                else
                {
                    throw new DamjanException("The number you entered is NOT between 10-20"); // This will 100% throw FormatException, using the throw keyword
                }

                Animal animal = animals.FirstOrDefault(a => a.Name == "Stojan");
                Console.WriteLine(animal.Name); // This line could throw NullReferenceException
            }
            catch (FormatException ex) // This catch is the handling of all FormatException errors that could happen
            {
                Console.WriteLine($"{userInput} is not a number. {ex.Message}");
                number = 0;
            }
            catch (NullReferenceException ex) // This catch is the handling of all NullReferenceException errors that could happen
            {
                Console.WriteLine($"There was an NullRefereceException {ex.Message} {ex.StackTrace}");
            }
            catch (DamjanException ex) // This catch is the handling of all DamjanException errors that could happen
            {
                Console.WriteLine($"Damjan Exception happend: {ex.Message}");
            }
            catch (Exception ex) // This catch is the handling of all other exception, similar like what default is doing in switch-case scenario
            {
                Console.WriteLine($"ERROR happend: {ex.Message}");
            }
            finally // This block will always be excecuted no matter what (success or fail)
            {
                Console.WriteLine("I will be execetuted no matter what");
            }

            Console.WriteLine($"The number is {number}");

            Console.ReadLine();
        }
    }
}
