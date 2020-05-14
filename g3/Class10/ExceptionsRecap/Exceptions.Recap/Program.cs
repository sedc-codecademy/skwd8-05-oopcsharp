using System;

namespace Exceptions.Recap
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

            int addResult, subResult, mulResult;
            decimal divResult;

            try
            {

            }
            catch (Exception ex)
            {

            }
            finally
            {

            }


            Console.ReadLine();
        }
    }
}
