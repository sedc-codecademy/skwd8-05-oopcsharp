using System;

namespace Exceptions.MultiCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            try
            {
                //throw new FormatException();
                //throw new ArgumentNullException();
                Console.WriteLine("Type something...");
                //byte something = byte.Parse(null);
                byte something = byte.Parse(Console.ReadLine());

                Console.WriteLine("This is a code that will be executed only when no exception is thrown");

            }
            catch(OverflowException ex)
            {
                // OverflowException -> ArithmeticException -> SystemException -> Exception
                // In case we enter number smaller than 0 and bigger than 255
                Console.WriteLine("OverflowException");
                Console.WriteLine("This happens when overflow of the variable is present.");
                throw;
            }
            catch (FormatException ex)
            {
                // FormatException -> SystemException -> Exception
                // In case we entered text or nothing (just ENTER) instead of number
                Console.WriteLine("FormatException");
                Console.WriteLine(ex.Message);
                throw;
            }
            catch(ArgumentNullException ex)
            {
                // ArgumentNullException -> ArgumentException -> SystemException -> Exception
                // In case instead of Console.ReadLine() we entered and try to parse 'null'
                Console.WriteLine("ArgumentNullException");
                Console.WriteLine($"ArgumentNullExcetpion message is this: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                //some logic here
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                Console.WriteLine("Type something to end execution.");
                Console.ReadLine();
            }
        }
    }
}
