using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 10, 23, 7, 19, 55, 23, 11, 65 };

            Console.WriteLine("Original list:");
            PrintNumbers(numbers);

            List<int> numbersLargerOf10 = numbers.Where(number => number > 10).ToList();
            
                Console.WriteLine("Numbers larger of 10");
            PrintNumbers(numbersLargerOf10);

            List<int> numbersBetween20And60 = numbers.Where(number => number > 20 && number < 60).ToList();

            Console.WriteLine("Number between 20 and 60");
            PrintNumbers(numbersBetween20And60);

            List<string> names = new List<string>() { "Risto", "Damjan", "Darko", "Tea", "Risto" };

            //string firstName = names.First();
            string firstName = names.FirstOrDefault();
            Console.WriteLine(firstName);

            string lastName = names.Last();
            Console.WriteLine(lastName);

            List<string> emptyList = new List<string>();
            string firstElement = emptyList.FirstOrDefault();
            string lastElement = emptyList.LastOrDefault();

            string firstElementThatHasAtLeast6Letters = names.FirstOrDefault(name => name.Length == 6);
            //string firstElementThatHasAtLeast6Letters = names.Where(name => name.Length == 6).FirstOrDefault();
            Console.WriteLine(firstElementThatHasAtLeast6Letters);

            //string firstElementThatHasAtLeast5Letters = names.FirstOrDefault(name => name.Length == 5);

            int singleNumberLargerThan50First = numbers.First(number => number > 50);
            //int singleNumberLargerThan50 = numbers.Single(number => number > 50);

            int maxNumber = numbers.Max();
            int minNumber = numbers.Min();
            double average = numbers.Average();

            Console.WriteLine($"Max {maxNumber}; Min {minNumber}; Average {average}");

            double averageOfNumbersAbove30 = numbers.Where(number => number > 30).Average();
            Console.WriteLine($"Above 30 average: {averageOfNumbersAbove30}");

            List<int> acOrder = numbers.OrderBy(number => number).ToList();
            PrintNumbers(acOrder);
            Console.WriteLine("-----------------------");
            List<int> descOrder = numbers.OrderByDescending(number => number).ToList();
            PrintNumbers(descOrder);

            List<int> listOfFirst5 = numbers.Take(5).ToList();
            Console.WriteLine("-----------------------");
            PrintNumbers(listOfFirst5);

            List<int> skipTwoElements = numbers.Skip(2).ToList();
            Console.WriteLine("-----------------------");
            PrintNumbers(skipTwoElements);

            List<int> subset = numbers.Skip(2).Take(5).ToList();
            Console.WriteLine("-----------------------");
            PrintNumbers(subset);
        }

        public static void PrintNumbers(List<int> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
