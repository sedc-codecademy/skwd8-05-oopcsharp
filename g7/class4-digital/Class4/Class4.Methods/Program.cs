using System;

namespace Class4.Methods
{
	class Program
	{
		// Next to the name of the function we write the type of the return
		// Void -> Do not return anything
		// THIS IS THE DECLARATION
		static void CheckDroids1()
		{
			Console.WriteLine("These aren't the droids you are looking for.");
			Console.ReadLine();
		}

		// Method with paramters
		static void CheckDroids2(bool isJedi)
		{
			if (isJedi)
			{
				Console.WriteLine("These aren't the droids you are looking for.");
			} else
			{
				Console.WriteLine("Take the droids. It's cool!");
			}
			Console.ReadLine();
			//return "Something else"; // We can't use this since this is a void method
		}


		// C# made sure that:
		// 1. We must return something
		// 2. That something must be string
		// 3. We must give 1 parameter
		// 4. That parameter must be bool

		// C# Method Rules:
		// 1. You can't return more than 1 value ( 1 value == 1 type )
		// 2. You can return as much parameters as you need to and each has it's own type
		static string JediMindTrick1(bool isJedi)
		{
			if (isJedi)
			{
				return "These aren't the droids you are looking for.";
			} else
			{
				return "Take the droids. It's cool!";
			}
		}

		// Is the trick success
		// This returns bool type
		static bool JediMindTrick2(bool isJedi, int jediLevel)
		{
			if (isJedi && jediLevel > 3)
			{
				Console.WriteLine("We are in the JediMindTrick2 method!");
				return true;
			}
			else
			{
				return false;
			}
		}

		// JS function
		//function JediMindTrick2(isJedi, jediLevel)
		//{
		//	if (isJedi && jediLevel > 3)
		//	{
		//		Console.WriteLine("We are in the JediMindTrick2 method!");
		//		return "asd";
		//	}
		//	else
		//	{
		//		return false;
		//	}
		//}

		// Everything you want to execute, you must add to the Main method
		static void Main(string[] args)
		{
			// THIS IS THE CALLING OF THE FUNCTION
			CheckDroids1();
			CheckDroids2(false);

			// void methods return nothing and that is why we can't use them as values
			// void empty = CheckDroids1(); // we can't use it as a value
			// Console.WriteLine(CheckDroids1()); // We can't use it as a value
			string answer = JediMindTrick1(true);
			bool isTrickSuccess = JediMindTrick2(true, 4);
			Console.WriteLine(answer);
			Console.WriteLine(isTrickSuccess);
			Console.ReadLine();
		}
	}
}
