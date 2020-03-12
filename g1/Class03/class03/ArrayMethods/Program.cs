using System;

namespace ArrayMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array.indexOf
            int[] array = new int[] { 1, 2, 3, 4, 5 };

            // we get the index of 2 in array
            int indexOfTwo = Array.IndexOf(array, 2);
            Console.WriteLine(indexOfTwo);

            // we revert the array
            Array.Reverse(array);

            foreach (var number in array)
            {
                Console.WriteLine(number);
            }

            // we copy the array in another array
            int[] clonedArray = new int[5];
            Array.Copy(array, clonedArray, 5);

            foreach (var number in clonedArray)
            {
                Console.WriteLine(number);
            }

            // sort the array ASC
            Array.Sort(array);
            foreach (var number in array)
            {
                Console.WriteLine(number);
            }

            // get the length of array
            int length = array.Length;
            Console.WriteLine(length);

            // get the last index of element in array
            int[] newArray = new int[] { 1, 2, 3, 1, 5, 6, 7, 8 };
            int lastIndexOfOne = Array.LastIndexOf(newArray, 1);
            Console.WriteLine(lastIndexOfOne);

            Console.ReadLine();
        }
    }
}
