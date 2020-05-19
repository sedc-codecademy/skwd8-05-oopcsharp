using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PostsAPI.APIExceptionHandlers
{
    public class BadRequestException : Exception
    {

        public int StatusCode { get; set; }
        public string UniqueExceptionCode { get; set; }

        public BadRequestException(string message, Exception innerException, int statusCode)
            :base(message, innerException)
        {
            this.StatusCode = statusCode;
        }
    }
}
