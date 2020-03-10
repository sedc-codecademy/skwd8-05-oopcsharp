using System;

namespace SEDC.Class03.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ArrayDeclaration

            // declaration and initialization
            int[] integerArray = new int[3];

            integerArray[0] = 1;
            integerArray[1] = 2;
            integerArray[2] = 3;

            Console.WriteLine(integerArray);
            Console.WriteLine(integerArray[2]);

            //integerArray[3] = 10;

            string[] fullStringArray = 
                new string[]
                { "asd", "dsa", "asdf", "asdfg", "asdfgh" };

            int[][] arrayOfArrays = new int[][]
            {
                new int[] { 1,3,4,6 },
                new int[] { 2,3,5,7 }
            };

            //for(int i = 0; i < arrayOfArrays.Length; i++)
            //{
            //    for(int j = 0; j < arrayOfArrays[i].Length; j++)
            //    {
            //        Console.WriteLine(arrayOfArrays[i][j]);
            //    }
            //    Console.WriteLine("Row: " + i);
            //}

            int[] indexOfArray = new int[] { 1,2,3,4,6,7,8,9,1 };
            
            int foundIndex = Array.IndexOf(indexOfArray, 6);
            Console.WriteLine("Found value on index: " + foundIndex);

            int notFoundIndex = Array.IndexOf(indexOfArray, 1000);
            Console.WriteLine("Found Value on index: " + notFoundIndex);

            Console.WriteLine(indexOfArray[1]);

            Array.Reverse(indexOfArray);

            Console.WriteLine(indexOfArray[1]);

            Array.Resize(ref indexOfArray, 15);

            // int defaultInteger = default;

            Console.WriteLine("Printing resized array");
            for (int i = 0; i < indexOfArray.Length; i++)
            {
                Console.WriteLine(indexOfArray[i]);
            }

            foreach(int element in indexOfArray)
            {
                Console.WriteLine("ForEachLoop: " + element);
            }

            #endregion


            #region Excersise06

            Console.Clear();

            string[] fullNames = new string[0];
            while (true)
            {
                Console.WriteLine("Enter name: ");
                string inputName = Console.ReadLine();
                Array.Resize(ref fullNames, fullNames.Length + 1);
                fullNames[fullNames.Length - 1] = inputName;

                Console.WriteLine("Do you want to enter another name? Y/N");
                string continueEnteringNames = Console.ReadLine();
                if (continueEnteringNames == "y")
                {
                    continue;
                }
                if (continueEnteringNames == "n")
                {
                    foreach (var element in fullNames)
                    {
                        Console.WriteLine(element);
                    }
                    break;
                }
            }
            #endregion


            Console.ReadLine();
        }
    }
}
