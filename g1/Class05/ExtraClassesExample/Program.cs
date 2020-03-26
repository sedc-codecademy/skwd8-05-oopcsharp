using System;

namespace ExtraClassesExample
{
    public class Car
    {
        public string Model;
        public string RegisterNumber;
        public DateTime DateOfProduction;

        public void CarInfo()
        {
            Console.WriteLine($"MODEL: {Model} \nREGISTER NM: {RegisterNumber} \nYEAR OF PRODUCTION: {DateOfProduction.Year}");
        }
        
    };

    public class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        private bool IsAdult;

        private void IsUserAdult()
        {
            if (Age >= 18)
                IsAdult = true;
            else
                IsAdult = false;
        }

        public void GiveMeBeer()
        {
            IsUserAdult();
            if (IsAdult)
                Console.WriteLine($"Here you have your beer {FirstName}, it will cost you 5$");
            else
                Console.WriteLine($"Sorry {FirstName} {LastName}, beer is for adults only, you have only {Age}, here you have your Coca Cola!");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Car audi = new Car();
            audi.Model = "AUDI";
            audi.RegisterNumber = "AB-123-PP";
            audi.DateOfProduction = new DateTime(2012, 05, 22);
            audi.CarInfo();

            Console.WriteLine("--------------------------------------------------");

            Person person = new Person();
            person.FirstName = "Petko";
            person.LastName = "Petkovski";
            person.Age = 17;

            person.GiveMeBeer();

            Console.ReadLine();
        }
    }
}
