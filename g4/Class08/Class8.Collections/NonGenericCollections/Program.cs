using System;
using System.Collections;

namespace NonGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays review
            int[] numbers = new int[3];
            int[] otherNumbers = new int[3] { 1, 3, 5 };
            int[] anotherNumbers = { 2, 4, 6 };

            // Creating an empty ArrayList
            ArrayList firstArrayList = new ArrayList();

            // Adding elements in the ArrayList
            firstArrayList.Add(12);
            firstArrayList.Add("String type");
            firstArrayList.Add(true);
            firstArrayList.Add(anotherNumbers);

            foreach (var item in firstArrayList)
            {
                Console.WriteLine(item);
            }

            // Removing elements from ArrayList
            firstArrayList.Remove(anotherNumbers);

            foreach (var item in firstArrayList)
            {
                Console.WriteLine(item);
            }

            // we need to explicitly cast the element in order to use it's type
            int check = (int) firstArrayList[0];

            firstArrayList.AddRange(new int[2] { 30, 40 });

            // We can't use the .Sort() method on ArrayLists
            // firstArrayList.Sort();

            Console.WriteLine($"The capacity of the FirstArrayList is {firstArrayList.Count}");

            Console.ReadLine();
        }
    }
}
