using System;

namespace SEDC.Class02
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Declaration and initialization
            //int someValue;
            //someValue = 20;
            //Console.WriteLine(someValue);                            
            #endregion

            #region Declaration and initialization inline
            //int number = 10;
            //short shortNumber = 2;
            //long longNumber = 12312432432423432;
            //char character = 'M';
            //string fullName = "Martin Panovski";
            //float floatValue = 22.5F;
            //double doubleValue = 32.3459843;
            //bool boolValue = true;

            //Console.WriteLine(number);
            //Console.WriteLine(shortNumber);
            //Console.WriteLine(longNumber);
            //Console.WriteLine(character);
            //Console.WriteLine(fullName);
            //Console.WriteLine(floatValue);
            //Console.WriteLine(doubleValue);
            //Console.WriteLine(boolValue);
            #endregion

            #region DateTime data type
            //DateTime data type
            //DateTime date = new DateTime();
            //Console.WriteLine(DateTime.Now);
            //Console.WriteLine(date.AddDays(2));
            //Console.WriteLine(DateTime.Now.AddDays(1));
            #endregion

            #region Operators and thier usage
            //double num1 = 234;
            //double num2 = 123;
            //double sum = num1 + num2;
            //Console.WriteLine(sum);

            //double dif = num1 - num2;
            //double dif2 = num2 - num1;
            //Console.WriteLine(dif);
            //Console.WriteLine(dif2);

            //double multiply = num1 * num2;
            //Console.WriteLine(multiply);

            //double div = num1 / num2;
            //Console.WriteLine(div);

            //bool isHigher = num1 > num2;
            //Console.WriteLine(isHigher);
            #endregion

            #region Strings and string concatenation
            //string firstName = "Ivo";
            //string lastName = "Kostovski";
            //string email = "ivo.kostovski@gmail.com";

            //Console.WriteLine("Hello students! I am " + firstName + " " + lastName + " and my email is " + email);
            //Console.WriteLine("Hi I am \"Ivo\"");

            //Console.WriteLine(@"Hi my name is """ + firstName + @"""");
            //Console.WriteLine($"Hi my name is {firstName} {lastName}");
            #endregion

            #region Data type conversion

            //Console.WriteLine("=============================");
            //Console.WriteLine("Please enter something: ");
            //string input = Console.ReadLine();

            //Console.WriteLine("You enter " + input.GetType());

            //int parsedInput = int.Parse(input);
            //Console.WriteLine("Parsed input " + parsedInput.GetType());


            //int convertedInput = Convert.ToInt32(input);
            //Console.WriteLine("Converted input " + convertedInput.GetType());

            //int parsedValue;
            //bool isParsed = int.TryParse(input, out parsedValue);
            //Console.WriteLine("Try parse: " + isParsed);

            //double parsedDoubleValue;
            //bool isDoubleParsed = double.TryParse(input, out parsedDoubleValue);
            //Console.WriteLine("Can parsed double value: " + isDoubleParsed);
            //Console.WriteLine("Parsed value: " + parsedDoubleValue);

            //int input1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(input1);

            #endregion

            #region Branching
            //int num3 = 234;
            //double num4 = 123.23;
            //if (isDoubleParsed)
            //{
            //    Console.WriteLine("You win!");
            //}
            //else
            //{
            //    Console.WriteLine("You loose!");
            //}

            //if (!isDoubleParsed)
            //{
            //    Nested if statement
            //    if (num3 == Convert.ToInt32(num4))
            //    {
            //        //Do something
            //    }
            //    else
            //    {
            //        Console.WriteLine("Nested final!");
            //    }
            //}
            //else if(num1 > num2)
            //{
            //    //Do something else
            //}
            //else
            //{
            //    Console.WriteLine("Final");
            //}


            //switch (num3)
            //{
            //    case 1:
            //        Console.WriteLine("One");
            //        break;
            //    case 234:
            //        Console.WriteLine("Bingo!");
            //        break;
            //    default:
            //        Console.WriteLine("Default");
            //        break;
            //}
            #endregion



            Console.ReadLine();
        }
    }
}
