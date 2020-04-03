using System;
using System.Collections.Generic;
using System.Text;

namespace SubjectServices
{
    class SubjectCodeGenerator
    {
        public static int GenerateSubjectCode()
        {
            // using Random class that comes from the System namespace (C# built in class)
            Random randomNumber = new Random();

            // Next() method that accepts range from, to 
            int code = randomNumber.Next(0, 10);

            return code;
        }
    }
}
