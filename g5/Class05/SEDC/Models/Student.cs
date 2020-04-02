using System;

namespace Models
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Subject[] Subjects { get; set; }
        private int NumberOfSubjects { get; set; }

        public Student(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Subjects = new Subject[10];
            NumberOfSubjects = 0;
        }

        public void AddSubject(Subject subject)
        {
            if(NumberOfSubjects == 10)
                return;

            //foreach (var s in Subjects)
            //{
            //    if(s == null)
            //        break;

            //    if(s.Name == subject.Name)
            //        return;
            //}

            for (int i = 0; i < NumberOfSubjects; i++)
            {
                if(Subjects[i].Name == subject.Name)
                    return;
            }

            Subjects[NumberOfSubjects] = subject;
            NumberOfSubjects++;
        }

        public string GetStudentInfo()
        {
            string info = $"{FirstName} {LastName} ({DateOfBirth.ToString("dd.MM.yyyy")})\nLista na predmeti:\n";

            for (int i = 0; i < NumberOfSubjects; i++)
            {
                info += $"{i + 1}. {Subjects[i].Name} ({Subjects[i].NumberOfClasses})\n";
            }

            return info;
        }
    }
}
