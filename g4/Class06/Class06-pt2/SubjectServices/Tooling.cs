using System;
using System.Collections.Generic;
using System.Text;

namespace SubjectServices
{
    public class Tooling
    {
        public string MainIDE { get; set; }

        public string AlternativeIDE { get; set; }

        public int Code;

        // constructor
        public Tooling()
        {
            // using static method GenerateSubjectCode() from the internal class SubjectCodeGenerator
            Code = SubjectCodeGenerator.GenerateSubjectCode();
        }
    }
}
