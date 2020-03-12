using System;

namespace Class03.Arrays
{
	class Program
	{
		static void Main(string[] args)
		{
			#region Arrays
			Console.WriteLine("We are learning Arrays!");
			// An empty array of integers with 3 items
			int[] simpleArrayOfInts = new int[3];
			simpleArrayOfInts[0] = 1;
			simpleArrayOfInts[1] = 10;
			simpleArrayOfInts[2] = 900;
			//simpleArrayOfInts[3] = 2; // This breaks the application
			Console.WriteLine(simpleArrayOfInts[2]); // 900

			// Quick ways of declaring an array
			string[] simpleArrayOfStrings1 = new string[] {"bob", "jill"};
			string[] simpleArrayOfStrings2 = { "bob", "jill", "greg" };
			Console.WriteLine(simpleArrayOfStrings1[0]);
			Console.WriteLine(simpleArrayOfStrings2[2]);
			#endregion
			#region ArrayMethods
			// Array features
			// Find the length of an array
			Console.WriteLine(simpleArrayOfInts.Length);
			// Find the index of an item in the array
			int indexOf900 = Array.IndexOf(simpleArrayOfInts, 900);
			int nonExistantIndex = Array.IndexOf(simpleArrayOfInts, 74);
			Console.WriteLine(indexOf900); // 2
			Console.WriteLine(nonExistantIndex); // -1
			// Changing the order of the array
			// This method changes the order of the original array
			Array.Reverse(simpleArrayOfInts);
			Console.WriteLine(simpleArrayOfInts[0]);
			// Resizing the array
			Array.Resize(ref simpleArrayOfInts, 6);
			Console.WriteLine(simpleArrayOfInts.Length);
			Console.WriteLine(simpleArrayOfInts[5]);
			//Array.Resize()

			#endregion
			Console.ReadLine();
		}
	}
}
