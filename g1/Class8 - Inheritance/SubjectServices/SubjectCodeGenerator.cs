using System;

namespace SubjectServices
{
    internal class SubjectCodeGenerator
    {
        public static int GenerateSubjectCode()
        {
            var rand = new Random();

            int code = rand.Next(0, 10);

            return code;
        }
    }
}