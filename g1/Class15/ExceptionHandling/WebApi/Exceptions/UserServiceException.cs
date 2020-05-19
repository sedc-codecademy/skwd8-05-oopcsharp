using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Exceptions
{
    public class UserServiceException : Exception
    {
        public UserServiceException(string message, Exception ex): base(message, ex)
        {

        }
    }
}
