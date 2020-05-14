using System;

namespace SimpleExercise
{
    class Program
    {
        static int TryParse(string input)
        {
            int num;
            try
            {
                num = int.Parse(input);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                num = 0;
            }
            return num;
        }
        static int AddNumbers(string num1, string num2)
        {
            return int.Parse(num1) + int.Parse(num2);
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Console.WriteLine("Enter 1st number");
            string num1 = Console.ReadLine();
            //int userNum1 = TryParse(num1); // Using of try/catch logic inside a method (TryParse->scroll up)

            Console.WriteLine("Enter 2nd number");
            string num2 = Console.ReadLine();
            //int userNum2 = TryParse(num2); // Using of try/catch logic inside a method (TryParse->scroll up)

            //Console.WriteLine($"The result is: {userNum1 + userNum2}");
            int result;
            try //Using of try/catch logic wrapped around the method call. If something goes wrong in the method AddNumbers the logic is in the catch block.
            {
                result = AddNumbers(num1, num2);
            }
            catch (Exception ex) //Handling of FormatException with regard to which of the 2 (or both) 'numbers' couldn't be parsed
            {
                Console.WriteLine(ex.Message);
                if (!int.TryParse(num1, out int res1) && !int.TryParse(num2, out int res2))
                    result = 0; 
                else if (!int.TryParse(num1, out int ress1))
                    result = 0 + int.Parse(num2);
                else
                    result = int.Parse(num1) + 0;

            }
            Console.WriteLine($"The result is: {result}");

            Console.ReadLine();

        }
    }
}
