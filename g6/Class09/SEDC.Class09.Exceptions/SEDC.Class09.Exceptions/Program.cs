using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace SEDC.Class09.Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // compile time error
            //int number = "Trajan";


            //var result = int.Parse(Console.ReadLine()) / int.Parse(Console.ReadLine());

            //Console.WriteLine(result);

            //var parsenNumber = TryParseOurWay(Console.ReadLine(), out int number);

            //if(parsenNumber)
            //{
            //    Console.WriteLine("Parsed number: " + number);
            //}
            //else
            //{
            //    Console.WriteLine("There is an error parsing");
            //}


            //try
            //{
            //    var result = int.Parse(Console.ReadLine()) / int.Parse(Console.ReadLine());

            //    Console.WriteLine(result);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (OverflowException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //var result1 = int.Parse(Console.ReadLine()) / int.Parse(Console.ReadLine());

            //Console.WriteLine(result1);

            //try
            //{
            //    // 1000 lines of code
            //}
            //catch (Exception ex)
            //{
            //    throw;
            //}

            // OpenConnectionToDbOrFile("asdasd");

            // NullReferenceExample();

            try
            {
                ThrowException();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Logging error: {ex.Message}");
                Console.WriteLine($"Logging stack trace: {ex.StackTrace}");

                //Debug.Write($"Logging error: {ex.Message}");
                //Debug.Write($"Logging stack trace: {ex.StackTrace}");
            }

            Console.ReadLine();
        }

        public static bool TryParseOurWay(string value, out int number)
        {
            try
            {
                number = int.Parse(value);
                return true;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                number = 0;
                return false;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                number = 0;
                return false;
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
                number = 0;
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                number = 0;
                return false;
            }
        }

        public static void OpenConnectionToDbOrFile(string text)
        {
            try
            {
                Console.WriteLine("Opening file OR database connection here");
                Thread.Sleep(5000);
                Console.WriteLine("Connection is open");
                int x = int.Parse(text);
            }
            catch (Exception ex)
            {
                Console.WriteLine("WriteToFileOrDatabase");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                // Connection.Close();
                Console.WriteLine("Closing connectio to db or file");
                Thread.Sleep(3000);
                Console.WriteLine("Connection closed");
            }
        }

        public static void NullReferenceExample()
        {
            var list = new List<User>
            {
                new User() { Id = 1, Name = "Trajan" },
                 new User() { Id = 2, Name = "Tosho" },
                 new User() { Id = 3, Name = "Bob" },
                 new User() { Id = 4, Name = "Bobski" },
                 new User() { Id = 5, Name = "TestUser" },
                 new User() { Id = 6, Name = "TestUser1" },
                 new User() { Id = 6, Name = null },
                 new User() { Id = 6, Name = "TestUser2" },
                 new User() { Id = 6,  Name = null },
                 new User() { Id = 6,  Name = null },
                 new User() { Id = 6, Name = "TestUser3" },
                 new User() { Id = 6, Name = "TestUser4" }
            };

            //var id = int.Parse(Console.ReadLine());
            //var user = list.FirstOrDefault(user => user.Id == id);

            //try
            //{
            //    Console.WriteLine(user.Name);
            //}
            //catch (NullReferenceException ex)
            //{
            //    Console.WriteLine("User with that id does not exists");
            //}

            foreach (var user in list)
            {
                try
                {
                    Console.WriteLine(user.Name.Trim());
                }
                catch (Exception)
                {
                    // log error in file
                }
            }
        }

        public static void ThrowException()
        {
            Console.WriteLine("Enter the letter a or b:");
            try
            {
                string letter = Console.ReadLine();
                letter = letter.ToLower().Trim();
                if (letter == "a" || letter == "b")
                {
                    Console.WriteLine($"You entered letter: {letter}");
                }
                else
                {
                    Exception customException = new Exception("This letter in not a or b");
                    customException.HelpLink = "www.sedc.project.com/exception2000";
                    throw customException;
                    //throw new Exception("This letter in not a or b short syntax");
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                Console.WriteLine("Not valid letter");
                throw ex;
            }

        }
    }
}
