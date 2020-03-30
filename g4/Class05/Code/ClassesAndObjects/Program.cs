using System;

namespace ClassesAndObjects
{
    // access modifier / class keyword / name of the class
    public class Student
    {
        // Default constructor
        public Student()
        {
        }

        // PROPERTIES   
        // access modifier / value type / name of the property
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        private int Age;

        //METHODS
        // access modifier / return type / name of the methods / (paramteres)
        public void SayHello()
        {
            Console.WriteLine($"Hello, I'm {FirstName} {LastName}!");
            HowOld(DateTime.Today);
            Console.WriteLine($"Also I am {Age} years old.");
        }

        private void HowOld(DateTime today)
        {
            if(today.Month < DateOfBirth.Month)
            {
                Age = today.Year - DateOfBirth.Year - 1;
            }
            Age = today.Year - DateOfBirth.Year;
        }
    }
    class Program
    {    
        static void Main(string[] args)
        {
            Student student01 = new Student();
            student01.FirstName = "Dejan";
            student01.LastName = "Jovanov";
            student01.DateOfBirth = new DateTime(1992, 1, 22);

            // We cannot access the private property Age here
            //student01.Age = 28;

            Console.WriteLine(student01.FirstName);
            //student01.SayHello();

            Student student02 = new Student();
            student02.FirstName = "Kristina";
            student02.LastName = "Spasevska";
            student02.DateOfBirth = new DateTime(1987, 3, 26);

            student02.SayHello();

            Console.ReadLine();
        }
    }
}
