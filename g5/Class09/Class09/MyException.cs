using System;

namespace Class09
{
    public class MyException : Exception
    {
        public MyException()
        {
            
        }
        public MyException(string message) : base(message)
        {
            
        }
    }
}
