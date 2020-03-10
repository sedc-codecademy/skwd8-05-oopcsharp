using System;

namespace ControlOfFlow
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter age:");
			int age = 0;
			bool isAgeCorrect = int.TryParse(Console.ReadLine(), out age);

			if(isAgeCorrect == true && age >= 0)
			{
				Console.WriteLine("Your age was recorded in the database!");
			} else
			{
				Console.WriteLine("That's probobly not your age! Go away!");
			}
			Console.ReadLine();

			// JS Convention of writing curly brackets
			if(true){

			}
			// C# Convention of writing curly brackets
			if (true)
			{

			}

			// Switch
			Console.WriteLine("Enter a week day:");
			int day = 0;
			bool isDayCorrect = int.TryParse(Console.ReadLine(), out day);

			switch (day)
			{
				case 1:
				case 2:
				case 3:
				case 4:
				case 5:
					Console.WriteLine("Work day :-(");
					break;
				case 6:
				case 7:
					Console.WriteLine("Chill time!");
					break;
				default:
					Console.WriteLine("No day like that!");
					break;
			}
			Console.ReadLine();
		}
	}
}
