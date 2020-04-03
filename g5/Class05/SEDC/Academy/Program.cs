using System;
using Models;

namespace Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: create subjects
            Subject subject1 = new Subject("JS Basic", 10);
            Subject subject2 = new Subject("JS Advance", 15);
            Subject subject3 = new Subject("C# Basic", 10);
            Subject subject4 = new Subject("C# Advance", 15);
            Subject subject5 = new Subject("MVC", 15);

            Subject[] subjects = new Subject[5] { subject1, subject2, subject3, subject4, subject5 };

            //TODO: Create students
            Student student1 = new Student("Martin", "Andreev", new DateTime(1993, 04, 02));
            Student student2 = new Student("Aleksandar", "Malinov", new DateTime(1993, 04, 03));

            Student[] students = new Student[2] { student1, student2 };

            //TODO: Create trainers
            Trainer trainer1 = new Trainer("Risto", "Panchevski");
            Trainer trainer2 = new Trainer("Trener", "SEDC");

            Trainer[] trainers = new Trainer[2] { trainer1, trainer2 };

            //TODO: Add subjects to a student
            students[0].AddSubject(subjects[0]);
            students[0].AddSubject(subjects[3]);
            students[0].AddSubject(subjects[0]);

            students[1].AddSubject(subjects[1]);
            students[1].AddSubject(subjects[4]);

            //TODO: Add subjects to trainers
            trainers[0].AddSubject(subjects[0]);
            trainers[0].AddSubject(subjects[2]);

            trainers[1].AddSubject(subjects[1]);
            trainers[1].AddSubject(subjects[3]);
            trainers[1].AddSubject(subjects[4]);
            trainers[1].AddSubject(subjects[4]);

            //TODO: Print academy info
            Console.WriteLine("Subjects:");
            foreach (var subject in subjects)
            {
                Console.WriteLine($"{subject.Name} ({subject.NumberOfClasses})");
            }

            Console.WriteLine("Students:");
            foreach (var student in students)
            {
                Console.WriteLine(student.GetStudentInfo());
            }

            Console.WriteLine("Trainers:");
            foreach (var trainer in trainers)
            {
                Console.WriteLine(trainer.GetTrainerInfo());
            }
        }
    }
}
