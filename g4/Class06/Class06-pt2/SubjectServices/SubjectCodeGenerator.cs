using System;
using System.Collections.Generic;
using System.Text;

namespace SubjectServices
{
    class SubjectCodeGenerator
    {
        public static int GenerateSubjectCode()
        {
            Random randomNumber = new Random();

            int code = randomNumber.Next(0, 10);

            return code;
        }
    }
}
