using SEDC.CustomExceptions.CustomExceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CustomExceptions.Helpers
{
    public static class Email
    {
        public static void SendEmail(string to, string from, string subject, string message, int years)
        {
            
            try
            {
                if(years > 0)
                {
                    Console.WriteLine($"From: {from} | To: {to} | Subject: {subject} | Message: {message}");
                }
                else
                {
                    throw new Exception("Something bad happened with the email service.");
                }                
            }
            catch (Exception ex)
            {
                throw new EmailNotSendException("The email was not sent!", ex.InnerException);
            }

            
        }
    }
}
