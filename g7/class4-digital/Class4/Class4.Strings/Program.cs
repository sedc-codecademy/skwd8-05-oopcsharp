using System;

namespace Class4.Strings
{
	class Program
	{
		static void Main(string[] args)
		{
			// Concatanation
			// What we will have as a result in the variable: "Bob is cool!"
			string normalConcat1 = "Bob " + "is cool!";

			// 1st parameter: the string
			// Other paramters after the first are values that should be replacing the {0} {1} numbers
			// What we will have as a result in the variable: "Bob is cool! another thing!"
			string formatConcat1 = string.Format("Bob {0} {1}", "is cool!", " another thing!");
			string formatConcat2 = string.Format("This is a sentence: {0}", formatConcat1);
			Console.WriteLine(normalConcat1);
			Console.WriteLine(formatConcat1);
			Console.WriteLine(formatConcat2);

			// String interpolation
			// WE MUST HAVE $ BEFORE THE "" TO USE THIS
			string interpolationConcat1 = $"This is a sentence: {normalConcat1}"; // C# 6
			Console.WriteLine(interpolationConcat1);

			// ESCAPE CHARACTERS
			// 1. By using \ character
			// Check your c:\drive
			Console.WriteLine("Check your c:\\drive");
			// We will have "fair" elections
			Console.WriteLine("We will have \"fair\" elections");
			// the \n sign means: new line
			Console.WriteLine("the \\n sign means: new line");

			// 2. By using @ character
			// Check your c:\drive
			Console.WriteLine(@"Check your c:\drive");
			// We will have "fair" elections
			Console.WriteLine(@"We will have ""fair"" elections");
			// the \n sign means: new line
			Console.WriteLine(@"the \n \n sign means: new line");

			// STRING FORMATTING
			// Currency
			// 1. Declare the string variable
			// 2. Lets find out what is the code in the initialization
			// 3. Execute whatever is there ( the method Format )
			// 4. The method Format returns a string
			// 5. Put that string in the variable
			string currencyFormating = string.Format("Bank account: {0:C}", 125.50);
			Console.WriteLine(currencyFormating);
			// Percentages
			string percentageFormating = string.Format("Battery: {0:P}", 0.5);
			Console.WriteLine(percentageFormating);
			// Custom formating
			string customFormating = string.Format("Phone: {0:(###) ##-###-###}", 38970555444);
			Console.WriteLine(customFormating);


			// Sring methods
			string ourString = "    We are learning C# and it is FUN and EASY. Okay maybe just FUN.     ";
			
			// Convert to lower case - Method ( does some action )
			string lowerCase = ourString.ToLower();
			string upperCase = ourString.ToUpper();
			Console.WriteLine(lowerCase);
			Console.WriteLine(upperCase);

			// Length - A property ( just keeps a value )
			int lengthOfString = ourString.Length;
			Console.WriteLine(lengthOfString);

			// Trim - Cuts the empty spaces from the front and back of the string
			string trimmedString = ourString.Trim();
			Console.WriteLine(trimmedString);

			// Split - Splits a string to an array of strings by a character or string
			string[] splittedString = ourString.Split(".");
			Console.WriteLine(splittedString[0]);
			Console.WriteLine(splittedString[1]);

			// starts with uppercase
			// StartsWith - We provide a string and it returns true or false depending on if that string really stars with that provided string
			bool doesItStartWith1 = ourString.StartsWith("Bob");
			bool doesItStartWith2 = ourString.StartsWith("    W");
			Console.WriteLine(doesItStartWith1);
			Console.WriteLine(doesItStartWith2);

			// IndexOf - It returns an integer ( the index ) of a staerting point of a string
			int indexOfString = ourString.IndexOf("C#");
			Console.WriteLine(indexOfString);

			// ToCharArray - converts a string in to an array of char ( array of characters )
			char[] ourStringCharacters = ourString.ToCharArray();
			Console.WriteLine(ourStringCharacters[7]);
			Console.WriteLine(ourStringCharacters[10]);
			Console.WriteLine(ourStringCharacters[12]);

			// Substring - Gets 2 int paramters ( index and length ) and cuts the string from the index to whicheer length
			string ourSubstring = ourString.Substring(5, 16);
			Console.WriteLine(ourSubstring);


			Console.ReadLine();
		}
	}
}
