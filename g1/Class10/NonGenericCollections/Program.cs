using System;
using System.Collections;

namespace NonGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays
            var numbers = new int[3];
            var otherNumbers = new int[2] { 10, 20 };
            var anotherNumbers = new int[] { 10, 20, 30 };

            // System.Collections namespace
            // ArrayList - collection of OBJECTS - .NET Framework 1.0 (extension on Arrays)
            // ArrayList ( Accepts all types and does not have constraint on number of elements )
            // ArrayList in C# as non generic type of collection
            // ArrayList resizes automatically as you add the elements.
            // ArrayList values must be cast to appropriate data types before using it.
            // ArrayList can contain multiple null and duplicate items.

            // ArrayList can store items(elements) of any datatype.
            ArrayList somethingOfSomething = new ArrayList(); // 0
            somethingOfSomething.Add(100); // 1
            somethingOfSomething.Add("Seavus Educational and Development Center"); // 2
            somethingOfSomething.Add(true); // 3

            // ArrayList can be accessed using foreach or for loop or indexer.
            foreach (var item in somethingOfSomething)
            {
                Console.WriteLine(item);
            }

            // The need of EXPLICIT CASTING
            var something = (string) somethingOfSomething[1];

            // Use Add(), AddRange(), Remove(), RemoveRange(), Insert(), InsertRange(), Sort(), Reverse() methods.
            // Cannot SORT elements with different data types
            somethingOfSomething.Sort();

            Console.WriteLine($"The capacity of the Turlitava is: {somethingOfSomething.Count}" );

            //Console.WriteLine(something);

            Console.ReadLine();
        }
    }
}
