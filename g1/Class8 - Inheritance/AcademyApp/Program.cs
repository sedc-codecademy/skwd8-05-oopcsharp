using AcademyApp.Entities;
using AcademyApp.Enums;
using AcademyApp.Helpers;
using SubjectServices;
using System;

namespace AcademyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var assistant = new Assistant();
            //var student = new Student();

            Trainer trainer = new Trainer("Miodrag", "Cekikj");
            trainer.DateOfBirth = new DateTime(1989, 5, 15);
            //trainer.Role = AcademyRole.Trainer;

            int[] numbers = new int[] { 1, 2, 3 };
            trainer.Subjects = new Subject[]
            {
                new Subject()
                {
                    Title = "C# Basic",
                    Semester = 2,
                    Tools = new Tooling()
                    {
                        MainIDE = "Visual Studio 2019",
                        AlternativeIDE = "Visual Studio Code"
                    }
                },
                new Subject()
                {
                    Title = "C# Advanced",
                    Semester = 2,
                    Tools = new Tooling()
                    {
                        MainIDE = "Visual Studio 2019",
                        AlternativeIDE = "Visual Studio Code"
                    }
                }
            };

            trainer.Greetings();

            var assistant = new Assistant();
            assistant.FirstName = "Goce";
            assistant.LastName = "Kabov";
            assistant.DateOfBirth = new DateTime(1992, 5, 15);
            assistant.Role = AcademyRole.Assistant;
            assistant.Greetings();

            var student1 = new Participant("Bob", "Marley");
            student1.Role = AcademyRole.Assistant;
            Console.ForegroundColor = ConsoleColor.Yellow;
            student1.PrintFullName();

            var student2 = new Participant()
            {
                FirstName = "Tupac",
                LastName = "Shakur"
            };

            var cSharpBasic = new Subject();
            cSharpBasic.Title = "C# Basic";
            cSharpBasic.Semester = 2;

            var cSharpAdvanced = new Subject();
            cSharpAdvanced.Title = "C# Advanced";
            cSharpAdvanced.Semester = 2;

            //participant4.Subjects = new string[] {"C# Basic", "C# Advanced"};

            student2.Subjects = new Subject[] { cSharpBasic, cSharpAdvanced };

            foreach (var subject in student2.Subjects)
            {
                Console.WriteLine(subject.Title);
            }

            student2.PrintFullName();

            var participants = new Participant[4];
            participants[0] = trainer;
            participants[1] = assistant;
            participants[2] = student1;
            participants[3] = student2;

            ParticipantHelper.FindParticipantByRole(participants, AcademyRole.Trainer);

            Console.ReadLine();
        }
    }
}