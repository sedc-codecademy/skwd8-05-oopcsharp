using System;

namespace SubjectServices
{
    class SubjectCodeGenerator
    {
        public static int GenerateSubjectCode()
        {
            Random rand = new Random();

            int code = rand.Next(0, 10);

            return code;
        }
    }
}