using System;

namespace Classes
{
    public class Participant
    {

        // Deafult constructor
        public Participant()
        {

        }

        // Constructor with one parametar
        public Participant(string firstName)
        {
            FirstName = firstName;
        }
        // Constructor with two parametars
        public Participant(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        // This is private property not accessible outside the class
        private int Age;

        public string FirstName;
        public string LastName;
        public DateTime DateOfBirth;
        public string[] Subjects;

        // property of type AcademyRole (enum) 
        public AcademyRole Role;

        public void Greetings()
        {
            Console.WriteLine($"Hello, I`m {FirstName} {LastName}");

            HowOld(DateTime.Today);
            Console.WriteLine($"Also, I`m {Age} years old. :)");
        }

        private void HowOld(DateTime today)
        {
            if (today.Month < DateOfBirth.Month)
                Age = today.Year - DateOfBirth.Year - 1;
        }

        public void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }

    // ENUM
    public enum AcademyRole
    {
        Trainer = 1,
        Assistant,
        Student
    }

    class Program
    {
        static void Main(string[] args)
        {
            Participant participant1 = new Participant();
            participant1.FirstName = "Miodrag";
            participant1.LastName = "Cekikj";
            participant1.DateOfBirth = new DateTime(1989, 5, 15);
            participant1.Role = AcademyRole.Trainer;
            participant1.Greetings();

            var participant2 = new Participant();
            participant2.FirstName = "Goce";
            participant2.LastName = "Kabov";
            participant2.DateOfBirth = new DateTime(1992, 5, 15);
            participant2.Role = AcademyRole.Assistant;
            participant2.Greetings();

            var participant3 = new Participant("Bob", "Marley");
            participant3.Role = AcademyRole.Assistant;
            Console.ForegroundColor = ConsoleColor.Yellow;
            participant3.PrintFullName();

            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine((int)participant1.Role);

            //Object Initializer - Instead of MULTIPLE CONSTRUCTORS
            //When I have a lot of properties to initialize :)
            var participant4 = new Participant()
            {
                FirstName = "Tupac",
                LastName = "Shakur",
                Subjects = new string[] { "C# Basic", "C# Advanced" }
            };

            participant4.PrintFullName();

            var participants = new Participant[4];
            participants[0] = participant1;
            participants[1] = participant2;
            participants[2] = participant3;
            participants[3] = participant4;

            //var numbers = new int[] { 10, 20, 40 };

            FindParticipantByRole(participants, AcademyRole.Trainer);

            Console.ReadLine();
        }

        // Method/Function 
        // INPUT: array of participants, ROLE   --- DONE :)
        // OUTPUT: Print FullName of all participants with that ROLE --- DONE :)
        // LOGIC -- DONE :)

        public static void FindParticipantByRole(Participant[] participants, AcademyRole role)
        {
            // role is parametar of type AcademyRole
            Console.ForegroundColor = ConsoleColor.Red;
            foreach (var participant in participants)
            {
                if (participant.Role == role)
                    participant.PrintFullName();
            }
        }
    }
}