using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arrays Declaration and Inicialization

            string[] namesEmpty = new string[5]; // Array of strings, this array will contain 5 elements, no matter if we initialize values or not(by default the values will be set to null), also the length property will acually use the "5" number in the square brackets.

            string[] namesWithValues = new string[5] { "Vukashin", "Viktorija", "Dejan", "Slavco", null }; // One way of initializeing values is using curly brackets, the count of values that we pass in the curly brackets must be the same as the length of the array(the number between the square brackets)

            string[] namesWithValuesShorter = new string[] { "Petar", "Aleksandra" }; // The other way of initializeing values is that we don't have to tell to the compiler what is the length of the array, we pass the values directly, the length of the array will be automatically determened based on how many elements we pass in the curly brackets

            string[] namesWithValuesShortest = { "Vukashin", "Dushko", "Angela" }; // This is equivalent to the previous example, the only difference is the shorter syntax, we exclude the "new string[]"



            string[] names; // This is only a declaration of an array, there is no initialization, this means that at this point we still don't have any array in names, the default value is null

            //string[] names = null; // This is what happens in the background if we don't assign(initialize) a value
            //Console.WriteLine(names[0]); // Will throw NullReferenceException, because names at this point it's not an array, it's just a null value

            names = new string[5]; // This is the moment where we initialize an array, we assign a value to the names variable, the value that we assign it's an array of strings with length of 5, after this moment forward we can use the indexer without throwing a NullReferenceException
            names[1] = "Vukashin";
            names[2] = "Monika";
            names[3] = null;
            #endregion

            #region For with arrays
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Name: {names[i]}");
            }
            #endregion

            #region Foreach (only works with arrays/collections)
            // Foreach is very similar to for-of in JavaScript, not for-in, it works ONLY with arrays/collections
            foreach (var name in names) // it will cycle through every element in names, each cycle the current element in the current cycle will be assigned in var name variable
            {
                Console.WriteLine($"Name: {name}");
            }
            #endregion

            #region Arrays helper methods
            int viktorijaIndex = Array.IndexOf(names, "Viktorija"); // Looks for a value "Viktorija" in names array, if there are multiple values "Viktorija" in names array, it will return the first element it will find

            // Arrays are statically declared, that means we can't change the structure of an array directly, we set a static number of length we set a type of elements and that's it.
            Array.Resize(ref names, 6); // For that reason we can use the Resize method, what Resize method does is in background it creates a new array with a new length(the second parameter in the method, ex: 6) and after that it puts all elements of the old array in the new one. After everything is finished, the newly created array is assigned to the names variable, now names variable contains the new created array.

            Array.Reverse(names); // Straight forward, it reverses an array

            Array.Sort(names); // Straight forward, it sorts an array, you can use it in a combination with .Reverse, if you want to sort ascending or descending

            string[] newNames = new string[names.Length]; // We create a new array with the current length of names
            names.CopyTo(newNames, 0); // As we can see CopyTo is not in the context of "Array" class, but every array object has it, we can use it to copy the elements from names to a new array of the same type, also we must specify the starting index as a second parameter
            #endregion

            Console.ReadLine();
        }
    }
}
