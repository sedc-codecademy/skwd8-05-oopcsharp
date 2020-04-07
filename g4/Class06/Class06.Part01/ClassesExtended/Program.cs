using ClassesExtended.Models;
using System;

namespace ClassesExtended
{
    class Program
    {
        static void FindStudent(Person[] arrayOfStudents, string name)
        {
            bool studentFound = false;
            while (!studentFound) //studentFound == false
            {
                foreach (var student in arrayOfStudents)
                {
                    if (student.FirstName == name)
                    {
                        Console.WriteLine($"Student {name} was found");
                        studentFound = true;
                    }
                }
                if (!studentFound)
                {
                    Console.WriteLine("There is no such student, please try again");
                    name = Console.ReadLine();
                }
            }
            
        }
        static void Main(string[] args)
        {
            #region ClassExamples
            // calling empty constructor
            Person trainer = new Person();
            trainer.FirstName = "Dejan";
            trainer.LastName = "Jovanov";

            // this won't work
            // trainer.Age = 28;

            //Console.WriteLine(trainer.PrintInfo());
            //Console.WriteLine(trainer.LastName);

            // calling constructor with parameteres
            Person trainer2 = new Person("Kristina", "Spasevska");
            trainer2.CalculateAge(new DateTime(1987, 03, 26));
            //Console.WriteLine(trainer2.PrintInfo());
            //trainer2.PrintFullInfo();

            // calling the third constructor with params from diferent type
            Person student = new Person("Bob Bobsky", 25);
            //student.PrintFullInfo();

            // example of array of type Person
            Person[] trainers = new Person[] { trainer, trainer2 }; 
            #endregion

            #region Student Excercise
            // create array of Persons
            // create a method that will iterate the array and find a specific Person

            Person[] students = new Person[]
            {
                new Person("Trpe", "Trkovski"),
                new Person("Bob", "Bobsky"),
                new Person("John", "Doe"),
                new Person("Mali", "Djokica")
            };

            Console.WriteLine("Please enter the first name of the student that you are looking for");
            string name = Console.ReadLine();
            FindStudent(students, name);

            #endregion

            

            Console.ReadLine();
        }
    }
}
