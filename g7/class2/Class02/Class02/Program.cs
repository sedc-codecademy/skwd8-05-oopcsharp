using System;

namespace Class02
{
	class Program
	{
		static void Main(string[] args)
		{
			// How we declared on JS
			// let myVariable = "bob";
			int number = 9000;
			double decimalNumber = 0.2222;

			// If we have a build error it will not let us run our application
			// It will give us the option to run the code from the last time we had a working version
			//Console.WriteLine("This is the BROKEN time!");
			//int anotherNumber = "bob";
			int empty;
			//empty = 3;
			number = 2000;
			//number = "Jill";
			Console.WriteLine(number);
			string name = "Bob";
			Console.WriteLine(name);
			//Console.WriteLine(empty);
			char someCharacter1 = 'B';
			char someCharacter2 = '&';
			Console.WriteLine(someCharacter1.GetType()); // GetType returns the type of the variable
			Console.WriteLine("This is the OKAY time!");
			Console.ReadLine();

		}
	}
}
