using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CustomExceptions.CustomExceptions
{
    public class EmailNotSendException : Exception
    {
        public EmailNotSendException(string message, Exception innerException)
            :base(message, innerException)
        {

        }
    }
}
