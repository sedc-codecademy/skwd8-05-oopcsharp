using Exceptions.Part2.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exceptions.Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>
            {
                new Animal { Name = "Dejan" },
                new Animal { Name = "Alek" },
                new Animal { Name = "Mirko" },
                new Animal { Name = "Dusica" },
                new Animal { Name = "Stojan" }
            };

            Console.WriteLine($"Enter 1st number between 0 and {animals.Count - 1} ");
            string userInput1 = Console.ReadLine();
            int userNum1 = 0;

            Console.WriteLine("Enter 2nd number");
            string userInput2 = Console.ReadLine();
            int userNum2 = 0;

            int addResult = 0, subResult = 0, mulResult = 0;
            decimal divResult = 0;

            try
            {
                userNum1 = int.Parse(userInput1);
                userNum2 = int.Parse(userInput2);

                if (userNum1 < 0 || userNum1 > animals.Count - 1) throw new NumberNotBetweenException($"{userNum1} is not between 0 and {animals.Count - 1}");

                addResult = userNum1 + userNum2;
                subResult = userNum1 - userNum2;
                mulResult = userNum1 * userNum2;
                divResult = userNum1 / userNum2;

                Console.WriteLine(animals[userNum1].Name);

                Console.WriteLine("Enter a name for the animal");
                string userInputName = Console.ReadLine();

                Animal myAnimal = animals.FirstOrDefault(a => a.Name == userInputName);
                Console.WriteLine(myAnimal.Name);
            }
            catch (FormatException ex)
            {
                userNum1 = 0;
                userNum2 = 0;
                Console.WriteLine($"ERROR happend during parsing: {ex.Message}");
            }
            catch (OverflowException ex)
            {
                userNum1 = 1;
                userNum2 = 1;
                Console.WriteLine($"ERROR happend during parsing: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                userNum2 = 1;
                Console.WriteLine($"ERROR happend during divide opertaion: {ex.Message}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"ERROR We don't have that much elements in our list {ex.Message}");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"ERROR null reference exception happened: {ex.Message}");
            }
            catch (NumberNotBetweenException ex)
            {
                Console.WriteLine($"ERROR {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message} {ex.StackTrace}");
            }
            finally
            {
                Console.WriteLine("I will be always excetuted, no matter what");
                //Looger.Log("Ajax was made to star wars api");
            }

            Console.WriteLine($"Add result: {addResult} Sub Result: {subResult} Mult Resut: {mulResult} Div esult: {divResult}");


            Console.ReadLine();
        }
    }
}
