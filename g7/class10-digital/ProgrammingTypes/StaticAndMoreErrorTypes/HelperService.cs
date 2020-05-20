using System;
using System.Collections.Generic;
using System.Text;

namespace StaticAndMoreErrorTypes
{
    public class HelperService
    {
        static HelperService()
        {
            nums = new List<int>();
        }

        public static List<int> nums { get; set; }

        public void Print()
        {
            Console.WriteLine("Something");
        }

        public static int TryParse(string userInput)
        {
            int num;
            try
            {
                num = int.Parse(userInput);
            }
            catch (Exception)
            {
                Console.WriteLine($"WARNING! Number parsing was no succesfull, insdead it was used 0");
                num = 0;
            }
            return num;
        }

        public static void AddNumbers(string userNum1, string userNum2, Movie movie)
        {
            int num1 = 0, num2 = 0;

            try
            {
                num1 = int.Parse(userNum1);
                num2 = int.Parse(userNum2);
                Console.WriteLine(movie.Name);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"You need to enter a valid string, not NULL {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"The conversion was not succesfulll {ex.Message}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"The number is too large for a 32-bit value {ex.Message}");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"Value is null {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Generic message {ex.Message}");
            }
        }
    }
}
