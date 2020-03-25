using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            #region String Building
            string academy = "Hello from SEDC Web Academy.";

            string group4 = academy + " " + "We are group 4 !";
            //Console.WriteLine(group4); 
            #endregion

            #region String Formatting
            string greeting = string.Format("{0} We are group 4", academy);
            //Console.WriteLine(greeting);

            string greetingMessage = "We are learning C#";
            string greeting2 = string.Format("{1} {0}", group4, greetingMessage);
            //Console.WriteLine(greeting2);

            string greeting3 = $"{group4} - {greetingMessage}";
            //Console.WriteLine(greeting3);

            // Currency formatting
            string currency = string.Format("{0:C}", 219);
            //Console.WriteLine(currency);

            // Percent formatting
            string percent = string.Format("{0:P}", .5);
            //Console.WriteLine(percent);

            // Custom formatting
            string myPhoneNumber = string.Format("{0:0##-###-###}", 078123456);
            //Console.WriteLine(myPhoneNumber);
            #endregion

            #region Escaping Strings
            // Escaping using \ character
            string escapeBackSlash = "Check you c:\\ drive";
            string escapeQuotes = "We will have \"fair\" elections";
            string escapeNewLine = "The \\n means: new line";
            //Console.WriteLine(escapeBackSlash);
            //Console.WriteLine(escapeQuotes);
            //Console.WriteLine(escapeNewLine);

            // Escaping a whole string using @
            string escapeBackSlash2 = @"Check you c:\ drive";
            string escapeQuotes2 = @"We will have ""fair"" elections";
            string escapeNewLine2 = @"The \n means: new line";
            //Console.WriteLine(escapeBackSlash2);
            //Console.WriteLine(escapeQuotes2);
            //Console.WriteLine(escapeNewLine2);

            // Combination of $ and @
            string combo = $@"My phone number is {myPhoneNumber}";
            //Console.WriteLine(combo); 
            #endregion

            #region String Methods
            // String Methods
            string testString = "   We are learning C# and it si FUN and EASY. " +
                "Ok or maybe just FUN.   ";
            string lower = testString.ToLower();
            string upper = testString.ToUpper();
            //Console.WriteLine(lower);
            //Console.WriteLine(upper);

            string trimmed = testString.Trim();
            //Console.WriteLine(trimmed);

            int stringLength = testString.Length;
            int trimmedStringLength = trimmed.Length;
            //Console.WriteLine(stringLength);
            //Console.WriteLine(trimmedStringLength);

            string[] splited = testString.Split('.');
            //Console.WriteLine(splited.Length);

            //Console.WriteLine(testString.StartsWith("W"));
            //Console.WriteLine(testString.StartsWith("   W"));

            // returns the starting index fo the letter/phrase
            // or -1 if it doesn't find nothing
            int indexOfString = testString.IndexOf("FUN");
            //Console.WriteLine(indexOfString);

            // starting from {parameter} to the end of the string
            string substring = testString.Substring(3);
            // starting from {first parameter} and take next {second parameter}
            string substring2 = testString.Substring(32, 20);

            char[] characters = testString.ToCharArray();
            Console.WriteLine(characters.Length);

            Console.WriteLine(substring);
            Console.WriteLine(substring2); 
            #endregion

            Console.ReadLine();
        }
    }
}
