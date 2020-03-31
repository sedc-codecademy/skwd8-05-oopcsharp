using System;

namespace Class4.DateTimeExample
{
	class Program
	{
		// Car Licenses Dot Com 
		// Get birth year, month and day from user ( valid )                        x
		// Create a date from those values and make sure it's not in the future     x 
		// Calculate age of the user                                                x
		// Start application for license ( 18 or + )                                x
		//    or refuse and show how many years are needed                          x
		// The app should be repeatable                                             x

		// Simple function that will write error message in the console so we don't write 3 lines of code every time we need red text
		static void ErrorMsg(string message)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(message);
			Console.ResetColor();
		}
		static int ValidatePositiveNumber(string number, int range)
		{
			int result = 0;
			bool isNumber = int.TryParse(number, out result);
			if (!isNumber)
			{
				ErrorMsg("Please check your format and press enter to try again...");
				Console.ReadLine();
				Console.Clear();
				return -1;
			}
			if (result < 1 || result > range)
			{
				ErrorMsg("The number is out of range. Press enter to try again...");
				Console.ReadLine();
				Console.Clear();
				return -1; 
			}
			return result;
		}
		static int CalculateAge(DateTime birthDate)
		{
			DateTime currentDate = DateTime.Now;
			int age = currentDate.Year - birthDate.Year;
			// birthday 28.12.2020 25 -> 26
			// We are offsetting the age by 1 year if the person has no birthday yet in this year
			if (birthDate.Month > currentDate.Month) age--;
			if (birthDate.Month == currentDate.Month && birthDate.Day > currentDate.Day) age--;
			return age;
		}

		static bool RunAgain()
		{
			while (true)
			{
				Console.WriteLine("Would you like to run again? Y/N");
				string answer = Console.ReadLine();
				if (answer.ToLower() == "y") return true;
				if (answer.ToLower() == "n") return false;
			}
		}
		static void Main(string[] args)
		{
			// 1. Request the inputs from the user
			// 2. Add validation method that validates the inputs from the user
			// 3. Change the implementation to use the valdation method 
			// 4. Ask for inputs each time we get invalid input
			// 5. We add the inputs and generate a DateTime value
			// 6. We created calculate age gunction
			// 7. We calcualted the age of the person
			// 8. We validated if its above or equal to 18 to give them a license
			// 9. We gave them a message with remaining years for those that are under 18
			// 10. We added a method for asking the user if they want to run the app again
			// 11. Incorporated the AskAgain method in the main logic
			while (true)
			{
				bool isValidInput = true;
				DateTime now = DateTime.Now;
				Console.WriteLine("Welcome to Car Licenses Dot Com");
				Console.WriteLine("Enter year of birth");
				int year = ValidatePositiveNumber(Console.ReadLine(), now.Year);
				if (year == -1) continue;
				Console.WriteLine("Enter month of birth");
				int month = ValidatePositiveNumber(Console.ReadLine(), 12);
				if (month == -1) continue;
				Console.WriteLine("Enter day of birth");
				int day = ValidatePositiveNumber(Console.ReadLine(), 31);
				if (day == -1) continue;

				DateTime date = new DateTime(year, month, day);
				if(date > DateTime.Now)
				{
					ErrorMsg("The date is in the future. Press enter to try again...");
					Console.ReadLine();
					Console.Clear();
					continue;
				}
				int age = CalculateAge(date);
				if (age >= 18) Console.WriteLine("Congrats! You can apply for your license!");
				else Console.WriteLine($"You need to grow {18-age} more years!");
				if (RunAgain() == false) break;
				Console.Clear();
			}
		}
	}
}
