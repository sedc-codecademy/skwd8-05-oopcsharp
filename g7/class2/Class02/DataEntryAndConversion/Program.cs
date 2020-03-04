using System;

namespace DataEntryAndConversion
{
	class Program
	{
		static void Main(string[] args)
		{
			// Enter data through the keyboard with Console.ReadLine()
			Console.WriteLine("Enter name:");
			string name = Console.ReadLine();
			Console.WriteLine("Enter Age:");
			string age = Console.ReadLine();
			// Try and convert the age to int
			int ageConverted1 = int.Parse(age);
			//int ageBroken1 = int.Parse("Bob");
			int ageConverted2 = Convert.ToInt32(age);
			int ageConverted3 = 0;
			bool isConvertingSuccessful = int.TryParse(age, out ageConverted3);
			int ageConverted4 = 0;
			bool brokenConvert = int.TryParse("Bob", out ageConverted4);
			Console.WriteLine("Parse: " + ageConverted1);
			Console.WriteLine("Convert: " + ageConverted2);
			Console.WriteLine("TryParse Result: " + ageConverted3 + " Success: " + isConvertingSuccessful );
			Console.WriteLine("Broken Result: " + ageConverted4 + " Success: " + brokenConvert);
			Console.WriteLine("Welcome " + name + " (" + age + ") ");
			Console.ReadLine();
		}
	}
}
