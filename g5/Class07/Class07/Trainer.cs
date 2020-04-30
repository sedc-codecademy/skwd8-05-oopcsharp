using System;

namespace Class07
{
    public class Trainer : Person 
    {
        public int Experience { get; set; }
        public string[] Subjects { get; set; }

        public Trainer(string firstName, string lastName, DateTime birthDate, int experience, string embg, string[] subjects)
            : base(firstName, lastName, birthDate, embg)
        {
            Experience = experience;
            Subjects = subjects;
        }

        public string GetEmbg()
        {
            //return base.PrintEmbg(); //private methods can be called only from the class where they are defined
            return string.Empty;
        }

        public new string GetInfo()
        {
            string info = $"Trainer: {FirstName} {LastName}\nSubjects:\n";

            foreach (var s in Subjects)
            {
                info += s + "\n";
            }

            return info;
        }

        //public new string GetBirthDate()
        //{
        //    return BirthDate.ToString("MM-dd-yyyy");
        //}

        public override string GetBirthDate()
        {
            return BirthDate.ToString("MM-dd-yyyy");
        }
    }
}
