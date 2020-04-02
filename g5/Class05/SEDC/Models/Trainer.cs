namespace Models
{
    public class Trainer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Subject[] Subjects { get; set; }
        private int NumberOfSubjects { get; set; }

        public Trainer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Subjects = new Subject[5];
            NumberOfSubjects = 0;
        }

        public void AddSubject(Subject subject)
        {
            if (NumberOfSubjects == 5)
                return;

            for (int i = 0; i < NumberOfSubjects; i++)
            {
                if (Subjects[i].Name == subject.Name)
                    return;
            }

            Subjects[NumberOfSubjects] = subject;
            NumberOfSubjects++;
        }

        public string GetTrainerInfo()
        {
            string info = $"{FirstName} {LastName}\nLista na predmeti koi gi predava:\n";

            for (int i = 0; i < NumberOfSubjects; i++)
            {
                info += $"{i + 1}. {Subjects[i].Name} ({Subjects[i].NumberOfClasses})\n";
            }

            return info;
        }
    }
}
