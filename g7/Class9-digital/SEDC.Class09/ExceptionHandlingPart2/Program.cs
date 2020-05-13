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
                number = int.Parse(userInput);

                if (number >= 10 && number <= 20)
                {
                    Console.WriteLine("The number you entered is between 10-20");
                }
                else
                {
                    throw new DamjanException("The number you entered is NOT between 10-20");
                }

                //Animal animal = animals.FirstOrDefault(a => a.Name == "Stojan");
                //Console.WriteLine(animal.Name);
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"{userInput} is not a number. {ex.Message}");
                number = 0;
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"There was an NullRefereceException {ex.Message} {ex.StackTrace}");
            }
            catch (DamjanException ex)
            {
                Console.WriteLine($"Damjan Exception happend: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR happend: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("I will be execetuted no matter what");
            }

            Console.WriteLine($"The number is {number}");

            Console.ReadLine();
        }
    }
}
