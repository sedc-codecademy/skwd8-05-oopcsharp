using System;

namespace Class07
{
    class Program
    {
        static void Main(string[] args)
        {
            var trainer = new Trainer("Risto", "Panchevski", DateTime.Now, 6, "111111111111", new []{"C# Basic", "C# Advance"});

            var student = new Student();
            student.FirstName = "Student";
            student.LastName = "1";

            var assistent = new Assistent("Vukashin", "Obradovic");

            Console.WriteLine(trainer.GetInfo());
            Console.WriteLine(student.GetInfo());
            Console.WriteLine(assistent.GetInfo());
        }
    }
}
