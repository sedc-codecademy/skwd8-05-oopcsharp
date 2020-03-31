using System;

namespace Class4.Dates
{
	class Program
	{
		static void Main(string[] args)
		{
			// Empty C# DateTime variable ( 01.01.001 default value )
			DateTime aDate = new DateTime();
			Console.WriteLine(aDate);
			Console.ReadLine();
			// Create a custom date
			DateTime aCustomDate = new DateTime(1992, 10, 15);
			Console.WriteLine(aCustomDate);
			Console.ReadLine();
			// Broken date time ( will throw an exception )
			//DateTime brokenDateTime = new DateTime(-1, 2, 5);
			//Console.WriteLine(brokenDateTime);
			//Console.ReadLine();

			// Date time prefference is set from the machine the code is running on
			string stringDate = "12-15-2012";
			DateTime convertedDate = DateTime.Parse(stringDate);
			Console.WriteLine(convertedDate);
			Console.ReadLine();

			// Current DateTime in C#
			DateTime currentDay = DateTime.Today;
			Console.WriteLine(currentDay);
			DateTime currentDayAndTime = DateTime.Now;
			Console.WriteLine(currentDayAndTime);
			Console.ReadLine();

			// Manipulate with dates
			// Adding stuff
			DateTime addedDays = currentDay.AddDays(5);
			Console.WriteLine(addedDays);
			DateTime addedMonths = currentDay.AddMonths(5);
			Console.WriteLine(addedMonths);
			DateTime addedYears = currentDay.AddYears(5);
			Console.WriteLine(addedYears);
			Console.ReadLine();

			// Removing stuff
			DateTime removedDays = currentDay.AddDays(-5);
			Console.WriteLine(removedDays);
			DateTime removedMonths = currentDay.AddMonths(-5);
			Console.WriteLine(removedMonths);
			DateTime removedYears = currentDay.AddYears(-5);
			Console.WriteLine(removedYears);
			Console.ReadLine();

			// Get Values
			Console.WriteLine(currentDay.Year);
			Console.WriteLine(currentDay.Month);
			Console.WriteLine(currentDay.Day);
			Console.ReadLine();

			// DateTime to String
			// Default
			string dateFormat = currentDay.ToString();
			string dateFormat1 = currentDay.ToString("MM/dd/yyyy");
			string dateFormat2 = currentDay.ToString("dddd, dd MMMM yyyy");
			string dateFormat3 = string.Format("Today is {0:MM/dd/yyyy}, {0:t} and after 5 days: {1:MM/dddd/yyyy}", currentDayAndTime, addedDays);
			Console.WriteLine(dateFormat);
			Console.WriteLine(dateFormat1);
			Console.WriteLine(dateFormat2);
			Console.WriteLine(dateFormat3);
			Console.ReadLine();
		}
	}
}
