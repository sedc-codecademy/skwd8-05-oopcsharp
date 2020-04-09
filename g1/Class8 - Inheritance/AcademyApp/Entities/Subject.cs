using SubjectServices;

namespace AcademyApp.Entities
{
    public class Subject
    {
        public string Title { get; set; }

        public int Semester { get; set; }

        public Tooling Tools { get; set; }
    }
}