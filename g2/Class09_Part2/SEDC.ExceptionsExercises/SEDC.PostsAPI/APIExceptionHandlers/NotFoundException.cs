using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PostsAPI.APIExceptionHandlers
{
    public class NotFoundException : Exception
    {
        public int StatusCode { get; set; }
        public NotFoundException(string message, Exception innerException, int statusCode)
            :base(message, innerException)
        {
            this.StatusCode = statusCode;
        }
    }
}
