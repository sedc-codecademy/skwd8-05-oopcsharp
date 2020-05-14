using System;
using System.Collections.Generic;
using System.Linq;

namespace Class09
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    //Insert logic that might throw an exception
            //}
            //catch (Exception ex)
            //{
            //    //It is executed when is exception is thrown
            //    //Handle the exception
            //}
            //finally
            //{
            //    //Logic that needs to be executed whether the exception is thrown or not
            //}


            //Console.WriteLine("Start execution");

            //try
            //{
            //    List<int> numbers = new List<int>();
            //    int firstNumber = numbers.First();
            //    //int lastNumber = numbers.Last(); //this line will never be executed, so the exception for last will not be thrown

            //    Console.WriteLine("Some other logic....");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Se sluci greska");
            //}


            //Console.WriteLine("Proceed with code execution.");

            try
            {
                Console.WriteLine("Vnesete ime i prezime:");
                string input = Console.ReadLine();
                string initials = GenerateUsername(input);
                Console.WriteLine($"{initials}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please contact IT department.");
            }
            finally
            {
                Console.WriteLine("End");
            }
        }

        public static string GenerateUsername(string name)
        {
            //IndexOutOfRangeException
            //InvalidOperationException
            string message = string.Empty;
            try
            {
                string[] names = name.Split(" ");

                if (names.Length > 2)
                {
                    throw new MyException("Ne podrzuvame povekje od 2 parametri");
                }

                string firstInit = string.Join("", names[0].Take(3));
                string secondInit = string.Join("", names[1].Take(3));

                List<int> list = new List<int>() {2};
                list.First();

                string t = null;
                string tToLower = t.ToLower();

                message = $"Username: {firstInit.ToLower()}.{secondInit.ToLower()}";
            }
            catch (IndexOutOfRangeException ex)
            {
                message = "Please enter name and surname";
                throw;
            }
            catch (InvalidOperationException ex)
            {
                message = "Error happened...";
            }
            catch (MyException ex)
            {
                message = ex.Message;
            }
            finally
            {
                Console.WriteLine("Finally block executed;");
            }

            return message;
        }
    }
}
