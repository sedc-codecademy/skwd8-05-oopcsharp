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

        public Tooling()
        {
            Code = SubjectCodeGenerator.GenerateSubjectCode();
        }
    }
}
