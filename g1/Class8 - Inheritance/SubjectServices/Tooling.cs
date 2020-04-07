namespace SubjectServices
{
    public class Tooling
    {
        public string MainIDE;

        public string AlternativeIDE;

        private int Code;

        // Constructor
        public Tooling()
        {
            Code = SubjectCodeGenerator.GenerateSubjectCode();
        }
    }
}