using System;

namespace ExceptionsInner.CustomExceptions
{
    // CUSTOM Exception 
    public class GoceAPIException : Exception
    {
        public GoceAPIException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}