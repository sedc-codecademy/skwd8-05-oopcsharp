using SEDC.CustomExceptions.CustomExceptions;
using SEDC.CustomExceptions.Helpers;
using System;

namespace SEDC.CustomExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Email.SendEmail("Ivo", "Martin", "Internal meeting", "Hi Ivo, can we have a meeting?", 26);

            try
            {
                Console.WriteLine("Please enter to:");
                string to = Console.ReadLine();
                Console.WriteLine("Please enter from:");
                string from = Console.ReadLine();

                Console.WriteLine("Please enter subject: ");
                string subject = Console.ReadLine();

                Console.WriteLine("Please enter message: ");
                string message = Console.ReadLine();

                Console.WriteLine("Please enter years: ");
                string years = Console.ReadLine();

                Email.SendEmail(to, from, subject, message, int.Parse(years));
            }
            catch(EmailNotSendException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            




            Console.ReadLine();
        }
    }
}
