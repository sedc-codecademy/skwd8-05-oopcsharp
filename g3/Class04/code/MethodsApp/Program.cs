using System;

namespace MethodsApp
{
    class Program
    {
        // // name and lastname are properties(technically fields) of the class Program
        //string name;
        //string lastname;

        // // How we write functions in JavaScript
        //function Sum(num1, num2)
        //{
        //    return num1 + num2;
        //}

        // How the same function as above looks in C#
        //int Sum(int num1, int num2)
        //{
        //    return num1 + num2;
        //}

        static double ValidateInput(string userInput)
        {
            string userInputCopy = userInput;
            double result;
            while (!double.TryParse(userInputCopy, out result))
            {
                Console.WriteLine("Please enter a valid number!");
                userInputCopy = Console.ReadLine();
            }
            return result;
        }

        static void Main(string[] args)
        {
            #region Methods
            Console.WriteLine("Enter the first number:");
            string num1Input = Console.ReadLine();
            double num1 = ValidateInput(num1Input);

            Console.WriteLine("Enter the second number:");
            string num2Input = Console.ReadLine();
            double num2 = ValidateInput(num2Input);

            double sumResult = num1 + num2;
            Console.WriteLine(sumResult);
            #endregion

            #region Strings

            char letter = 'T';
            char[] letters = new char[] { 'D', 'e', 'j', 'a', 'n' };

            string firstName = "Ivana";
            string lastName = "Stefanovska";
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            string stringBackticks = $"{firstName} {lastName}";
            Console.WriteLine(stringBackticks);

            string stringFormat = string.Format("{0} {1} is learning strings right now", firstName, lastName);
            Console.WriteLine(stringFormat);

            string currency = string.Format("{0:C}", 10.2);
            Console.WriteLine(currency);

            string percent = string.Format("{0:P}", .2);
            Console.WriteLine(percent);

            string phoneNumber = string.Format("{0:0##-###-###}", 079543123);
            Console.WriteLine(phoneNumber);

            string nameWithEscapeCharacter = "Dej\"a\"n";
            Console.WriteLine(nameWithEscapeCharacter);

            // @ escapes the whole string, no need to put \ before a character
            Console.WriteLine(@"De""j""an\n");

            string text1 = "This is the fourth class. We are learning strings, methods.";
            string text2 = "Hello world.";

            Console.Write(text1);
            Console.WriteLine(text2);

            string text3 = "This is the fourth class. We are learning strings, methods. \n";
            string text4 = "Hello world.";

            Console.WriteLine(text3);
            Console.Write(text4);

            #endregion

            #region String Methods
            string text = "    This is the fourth class. We are learning strings, methods. Hello world.       ";
            Console.WriteLine(text);
            Console.WriteLine(text.ToLower());
            Console.WriteLine(text.ToUpper());
            Console.WriteLine(text.Length);
            string[] splitText = text.Split(".");
            foreach (string textE in splitText)
            {
                Console.WriteLine(textE);
            }
            Console.WriteLine(text.StartsWith("t".ToUpper()));
            Console.WriteLine(text.Trim());
            char[] chars = text.ToCharArray();
            foreach (char charItem in chars)
            {
                Console.Write(charItem);
            }

            #endregion

            Console.Read();
        }
    }
}
