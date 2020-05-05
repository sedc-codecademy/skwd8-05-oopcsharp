using SEDC.Class07_Part1.Enums;
using SEDC.Class07_Part1.Models;
using System;

namespace SEDC.Class07_Part1
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Basic inheritance from Participant
            ////Instance of Participant class
            //Participant participant = new Participant();

            ////Instance of trainer
            //Trainer martin = new Trainer()
            //{
            //    FirstName = "Martin",
            //    LastName = "Panovski",
            //    Age = 26,
            //    Role = Role.Trainer,
            //    Subjects = new Subject[]
            //    {
            //        new Subject
            //        {
            //            Title = "C#Basic",
            //            Semester = 2
            //        }
            //    },
            //    Expertise = "Backend development",
            //    SpeackEnlgishLanguage = true
            //};
            //Console.WriteLine(martin.FirstName);


            ////Instance of assistant
            //Assistant ivo = new Assistant()
            //{
            //    FirstName = "Ivo",
            //    LastName = "Kostovski",
            //    Age = 30,
            //    Role = Role.Assistant,
            //    Subjects = new Subject[]
            //    {
            //        new Subject
            //        {
            //            Title = "HTML/CSS",
            //            Semester = 1
            //        },
            //        new Subject
            //        {
            //            Title = "BJS",
            //            Semester = 1
            //        },
            //        new Subject
            //        {
            //            Title = "AJS",
            //            Semester = 1
            //        },
            //        new Subject
            //        {
            //            Title = "C#Basic",
            //            Semester = 2
            //        }
            //    },
            //    Homeworks = new string[] { "Homework 1", "Homework 2", "Homework 3" }
            //};
            //foreach (string homework in ivo.Homeworks)
            //{
            //    Console.WriteLine(homework);
            //}


            ////Instance of student
            //Student dejan = new Student
            //{
            //    FirstName = "Dejan",
            //    LastName = "Jovanov",
            //    Age = 27,
            //    Role = Role.Student,
            //    Group = 2,
            //    Subjects = new Subject[]
            //    {
            //        new Subject
            //        {
            //            Title = "C#Basic",
            //            Semester = 2
            //        }
            //    }
            //};
            //Console.WriteLine(dejan.Subjects[0]);


            ////Instantiate object of Trainer with subjects by declaring subjects first, and then add them in the Subjects array in Trainer

            ////Same as instantiating Subjets previously in the code => At same time when instatiating an object of Trainer

            ////Subject sub1 = new Subject() { Title = "BasicC#", Semester = 2 };
            ////Subject sub2 = new Subject() { Title = "AJS", Semester = 1 };
            ////Trainer dragan = new Trainer()
            ////{
            ////    Subjects = new Subject[]
            ////    {
            ////        sub1,
            ////        sub2
            ////    }
            ////};
            #endregion


            #region Inheritance by inheriting the parent constructor
            //Trainer trainer = new Trainer();

            //Instance of trainer using constructor with 2 parameters (Using base constructor)
            //Trainer trainer1 = new Trainer("John", "Doe");

            //Instance of trainer using constructor with 3 parameters (Using base constructor)
            //Trainer trainer2 = new Trainer("John", "Doe", 20);

            Trainer trainer3 = new Trainer()
            {
                FirstName = "Martin",
                LastName = "Panovski",
                Age = 26,
                Role = Role.Trainer,
                Subjects = new Subject[]
                {
                    new Subject
                    {
                        Title = "c#basic",
                        Semester = 2
                    }
                },
                Expertise = "backend development",
                SpeackEnlgishLanguage = true
            };

            //Not accesible from outside due to its access modifier (protected)
            //trainer3.AccountBalance = 100;

            Assistant assistant = new Assistant
            {
                FirstName = "Ivo",
                LastName = "Kostovski",
                Age = 30,
                Role = Role.Assistant,
                Subjects = new Subject[]
                {
                    new Subject
                    {
                        Title = "HTML/CSS",
                        Semester = 1
                    },
                    new Subject
                    {
                        Title = "BJS",
                        Semester = 1
                    },
                    new Subject
                    {
                        Title = "AJS",
                        Semester = 1
                    },
                    new Subject
                    {
                        Title = "C#Basic",
                        Semester = 2
                    }
                },
                Homeworks = new string[] { "Homework 1", "Homework 2", "Homework 3" }
            };

            Student student = new Student
            {
                FirstName = "Dejan",
                LastName = "Jovanov",
                Age = 27,
                Role = Role.Student,
                Group = 2,
                Subjects = new Subject[]
                {
                    new Subject
                    {
                        Title = "C#Basic",
                        Semester = 2
                    }
                }
            };

            Console.WriteLine("=====================================");

            trainer3.PrintParticipantInfo();
            assistant.PrintParticipantInfo();
            student.PrintParticipantInfo();


            Console.WriteLine("===================");
            WebDevStudent webDevStudent = new WebDevStudent() { };
            
            #endregion

            Console.ReadLine();
        }
    }
}
