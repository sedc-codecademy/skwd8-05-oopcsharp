using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arrays intro
            // empty array with numbers
            int[] emptyArray = new int[3];
            emptyArray[0] = 10;
            emptyArray[1] = 20;
            emptyArray[2] = 30;
            //Console.WriteLine(emptyArray);
            Console.WriteLine(emptyArray[0]);

            // trying to set 4th element in the array
            // throws an exception !!!!!!!!!
            //emptyArray[3] = 40;

            string[] stringArray = new string[]
            {
                "Kristina",
                "Dejan"
            };

            bool[] boolArray = new bool[]
            {
                false,
                true,
                true,
                false
            };

            char[] charArray = new char[]
            {
                '*',
                '+',
                '-',
                '/'
            };

            // shroter way to initialize array
            int[] shorterWayArr = { 4, 10, 14 };
            Console.WriteLine(shorterWayArr[2]);
            #endregion

            #region Arrays methods
            double[] doubleArr = new double[]
            {
                12.6,
                50.99,
                1.05
            };
            // Length
            Console.WriteLine(doubleArr.Length);

            int[] intArr = new int[]
            {
                1, 2, 3, 4, 5, 3
            };
            // Array.Reverse 
            Array.Reverse(intArr);
            Console.WriteLine(intArr[0]);

            // Index Of - to find something in the array
            int indexArr = Array.IndexOf(intArr, 3);
            Console.WriteLine(indexArr);

            int indexNotFound = Array.IndexOf(intArr, 10);
            Console.WriteLine(indexNotFound);

            // Array.Resize to change lenght of an array
            // first parameter is the name of the array eq. ref myArray, the second is the new size/length we would like the array to have
            Array.Resize(ref intArr, 7);
            intArr[6] = 60;
            Console.WriteLine(intArr[6]);
            #endregion

            #region foreach
            // forach works with arrays only and loops through each element in the array
            string[] names = { "Will", "Sam", "Fiona", "May" };
            foreach (string name in names)
            {
                Console.WriteLine("Checking if name is Sam...");
                if (name == "Sam")
                {
                    Console.WriteLine("We found Sam!");
                    break;
                }

            }
            #endregion
            Console.ReadLine();
        }
    }
}
