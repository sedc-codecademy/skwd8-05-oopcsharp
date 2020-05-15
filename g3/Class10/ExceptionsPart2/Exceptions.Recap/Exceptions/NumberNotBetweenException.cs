using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions.Part2.Exceptions
{
    public class NumberNotBetweenException : Exception
    {
        public NumberNotBetweenException() : base() { }
        public NumberNotBetweenException(string message) : base(message) { }
    }
}
