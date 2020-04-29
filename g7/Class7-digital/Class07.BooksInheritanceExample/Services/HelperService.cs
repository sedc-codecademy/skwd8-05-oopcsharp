using System;
using System.Collections.Generic;
using System.Text;

namespace Class07.BooksInheritanceExample.Services
{
	public class HelperService
	{
		public void ErrorMsg(string message)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(message);
			Console.ResetColor();
		}
		public bool ValidateString(string value, int range)
		{
			if (value.Length < range) return false;
			return true;
		}
		public int ValidatePositiveNumber(string number, int range)
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
		public bool RunAgain()
		{
			while (true)
			{
				Console.WriteLine("Would you like to run again? Y/N");
				string answer = Console.ReadLine();
				Console.Clear();
				if (answer.ToLower() == "y") return true;
				if (answer.ToLower() == "n") return false;
			}
		}
	}
}
