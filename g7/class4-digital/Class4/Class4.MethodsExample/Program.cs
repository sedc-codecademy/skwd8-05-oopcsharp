using System;

namespace Class4.MethodsExample
{
	class Program
	{
		// The student name must be at least 2 characters                  x
		// The student name must not have a number in their name           x
		// The student name must exist in the students names database      x
		static bool ValidateName(string[] studentNames, string studentName)
		{
			studentName = studentName.Trim();
			if (studentName.Length < 2) return false;
			if (FindNumberInString(studentName)) return false;
			if (!FindUserInDb(studentNames, studentName)) return false;
			return true;
		}

		static bool FindNumberInString(string value)
		{
			char[] characters = value.ToCharArray();
			foreach (char character in characters)
			{
				int result;
				bool isNumber = int.TryParse(character.ToString(), out result); // ToString() - convert anything in to string
				if (isNumber) return true;
			}
			return false;
		}

		static bool FindUserInDb(string[] studentNames, string name)
		{
			foreach (string stName in studentNames)
			{
				if (stName.ToLower() == name.ToLower()) return true;
			}
			return false;
		}

		static void Main(string[] args)
		{
			// * - Style

			// 1. Asked for an input and shown the input
			// 2. Created validation method
			// 3. Incorporate validation method in to input logic
			// 4. Create while loop to ask question multiple times
			// *5. Solved issue with text from previous attempts cloging the console
			// *6. Added colors to be fancy
			// 7. Validation for numbers in a name
			// 8. Incorporated that validation with the ValidateName method
			// 9. Created a dummy database
			// 10. Created a function that checks an array of names if a name exists
			// 11. Modified the ValidateName method as well as the calling of the method to use the array of names
			// 12. We are a happy developer :-)

			// Simulation of DB
			string[] students = { "Bob", "Jill", "Greg", "Anne", "Piff" };

			while (true)
			{
				Console.Clear(); // Clears whatever is written in the console at this point in time
				Console.WriteLine("SEDC Names checker...");
				Console.Write("Please enter your name:");
				string name = Console.ReadLine();
				bool isNameValid = ValidateName(students, name);
				if (isNameValid)
				{
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine($"Welcome {name}! Good luck!");
					Console.ResetColor();
					Console.ReadLine();
					break;
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Incorrect name! Please hit enter and try again...");
					Console.ResetColor();
					Console.ReadLine();
				}
			}
		}
	}
}
