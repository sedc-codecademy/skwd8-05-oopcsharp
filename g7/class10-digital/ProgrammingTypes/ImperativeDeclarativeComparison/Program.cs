using System;
using System.Collections.Generic;
using System.Linq;

namespace ImperativeDeclarativeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            // Imperative example
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(i * 3);
            }

            numbers.Where(x => x < 5).ToList();

            // Declarative example
            numbers.ForEach(num =>
            {
                Console.WriteLine(Cube(num));
            });


            Console.ReadLine();
        }

        static int Cube(int num)
        {
            return num * 3;
        }
    }
}
