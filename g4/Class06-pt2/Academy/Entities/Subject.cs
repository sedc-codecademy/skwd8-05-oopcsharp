using SubjectServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Entities
{
    public class Subject
    {
        public string Title { get; set; }
        public int Semester { get; set; }

        public Tooling Tools;
    }
}
