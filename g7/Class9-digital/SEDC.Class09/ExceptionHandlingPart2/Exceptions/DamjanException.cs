using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandlingPart2.Exceptions
{
    public class DamjanException : Exception
    {
        public DamjanException() : base() { }
        public DamjanException(string? message) : base(message) { }
    }
}
