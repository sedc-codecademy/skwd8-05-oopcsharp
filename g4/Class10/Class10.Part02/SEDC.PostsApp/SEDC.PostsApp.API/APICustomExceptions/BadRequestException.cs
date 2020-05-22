using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PostsApp.API.APICustomExceptions
{
    public class BadRequestException : Exception
    {
        public int StatusCode { get; set; }
        public BadRequestException(string message, Exception innerException, int statusCode): base(message, innerException)
        {
            StatusCode = statusCode;
        }
    }
}
