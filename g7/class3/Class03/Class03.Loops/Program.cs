using System;

namespace Class03.Loops
{
	class Program
	{
		static void Main(string[] args)
		{
			#region For
			// For
			for(int i = 0; i <= 10; i++)
			{
				Console.WriteLine(i);
			}
			Console.ReadLine();

			// Infinite for loop ( Not where for shines )
			for (; ; )
			{
				Console.WriteLine("Enter X to continue...");
				string result = Console.ReadLine();
				// if(result != "x" && result != "X") // Alternate solution
				if(result.ToLower() != "x") // ToLower() -> Lower case a string
				{
					Console.WriteLine("That was not X! Press enter to try again...");
					Console.ReadLine();
				} else
				{
					Console.WriteLine("Pretty cool. You know the letter X!");
					break;
				}
			}
			Console.ReadLine();
			#endregion
			#region While
			// While with counter ( Not where while shines )
			int whileCounter = 0;
			while(whileCounter <= 10)
			{
				Console.WriteLine(whileCounter);
				whileCounter++;
			}
			Console.ReadLine();
			// Infinite while
			while (true) // Anything that will result in true or false is game
			{
				Console.WriteLine("Enter X to continue...");
				string result = Console.ReadLine();
				// if(result != "x" && result != "X") // Alternate solution
				if (result.ToLower() != "x") // ToLower() -> Lower case a string
				{
					Console.WriteLine("That was not X! Press enter to try again...");
					Console.ReadLine();
				}
				else
				{
					Console.WriteLine("Pretty cool. You know the letter X!");
					break;
				}
			}
			Console.ReadLine();
			#endregion

		}
	}
}
