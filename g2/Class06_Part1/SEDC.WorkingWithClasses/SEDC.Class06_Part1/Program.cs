using SEDC.Class06_Part1.Enums;
using SEDC.Class06_Part1.Models;
using System;

namespace SEDC.Class06_Part1
{
    class Program
    {
        public static void ExerciseEnums()
        {
            Console.WriteLine("Please enter which days you have lectures in SEDC?");
            Console.WriteLine("Enter the first day:");
            string firstDay = Console.ReadLine();
            Console.WriteLine("Enter the second day:");
            string secondDay = Console.ReadLine();

            if(firstDay.ToLower() == Days.Wednesday.ToString().ToLower())
            {
                Console.WriteLine("Today we learn enums");
            }
            else if(secondDay.ToLower() == Days.Friday.ToString().ToLower())
            {
                Console.WriteLine("Fridays are for exercies");
            }
            else
            {
                Console.WriteLine("Today you're definitely not learning anything!");
            }
        }

        static void Main(string[] args)
        {

            #region Constructuors
            // Instantiating an object using default constructor
            //Person martin = new Person();
            //martin.FirstName = "Martin";
            //martin.LastName = "Panovski";
            //martin.Age = 26;
            //martin.City = "Skopje";
            //martin.Country = "Macedonia";
            //Console.WriteLine(martin.FirstName);

            // Instantiating an object using default constructor
            Person person = new Person();
            //Instantiating an object by using custom constructor with all properties
            //Person ivo = new Person("Ivo", "Kostovski", 30, "Skopje", "Macedonia");

            //Bad practice
            //Person ivo1 = new Person("Ivo", "Kostovski", 30, null, null);
            //Console.WriteLine(ivo.FirstName + " " + ivo.LastName);


            //Instantiating an object by using custom constructor overload with only 3 properties
            Person student = new Person("Aleksandar", "Manasiev", 25);
            //Console.WriteLine($"Hello, my name is {student.FirstName} and I am a student!");


            //Instantiating an object by using the object initializer
            Academy academy = new Academy() { Name = "SEDC_WebDevelopment", Location = "Skopje" };
            Student student_martin = new Student() { FirstName = "Martin", LastName = "Panovski", Age = 26, Academy = academy, Subject = "BasicC#", Role = Roles.Student };
            //Console.WriteLine(student_martin.FirstName);

            Student student_ivo = new Student
            {
                FirstName = "Ivo",
                LastName = "Kostovski",
                Age = 30,
                Academy = new Academy
                {
                    Name = "SEDC_WebDesign",
                    Location = "Ohrid"
                },
                Subject = "BasicC#"
            };

            //Console.WriteLine(student_martin.Academy.Name);
            //Console.WriteLine(student_ivo.Academy.Name);
            Person person10 = new Person();
            foreach (var hobby in person10.Hobbies)
            {
                //Console.WriteLine("Hobbies: " + hobby);
            }


            Person trainer = new Person("Dejan", "Jovanov", 27, "Skopje", "Macedonia", Roles.Trainer);
            //Console.WriteLine(trainer.Role);
            #endregion

            #region Enums
            //Console.WriteLine(Days.Monday);
            ExerciseEnums();



            #endregion
            
            Console.ReadLine();

        }
    }
}
