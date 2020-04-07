using System;

namespace CodeOrginizer
{

    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person("John", 22);
            john.Address = new Address();
            john.Address.Name = "Wall street";
            john.Address.Number = 24;
            john.SSN = GenerateSSN();
            john.PrintPerson();

            Console.WriteLine("------------------------------------");

            Address bobsAdress = new Address()
            {
                Name = "Next To Wallstreet",
                Number = 1000
            };
            Address bobWorkingAdress = new Address()
            {
                Name = "Two streets after Wallstreet",
                Number = 101
            };
            Person bob = new Person()
            {
                Name = "Bob",
                Age = 55,
                Address = bobsAdress,
                SSN = GenerateSSN(),
                Job = new Job()
                {
                    Address = bobWorkingAdress,
                    CompanyName = "G1",
                    Role = Role.Designer
                }
            };

            bob.DevelopersSeacret();

            Console.ReadLine();
        }

        public static long GenerateSSN()
        {
            Random rand = new Random();
            return rand.Next(1000000, 9999999);
        }
    }

    public class Address
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public void PrintAdress()
        {
            Console.WriteLine($"Address Name: {Name}");
            Console.WriteLine($"Address Number: {Number}");
        }
    }

    public enum Role
    {
        WebDeveloper,
        Tester,
        Designer
    };

    public class Job
    {
        public string CompanyName { get; set; }
        public Address Address { get; set; }
        public Role Role { get; set; }

    }

    class Person
    {
        public string Name;
        public int Age;
        public Address Address;
        public Job Job;
        public long SSN;

        public Person()
        {
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void PrintPerson()
        {
            Console.WriteLine($"Name:{Name}, Age:{Age}, SSN:{SSN}");
        }

        public void DevelopersSeacret()
        {
            if (Job.Role == Role.WebDeveloper)
            {
                Console.WriteLine("The seacret of success is DEDUCATION");
            }
            else
            {
                Console.WriteLine($"{Name} is not developer, this is seacret only for developers!");
            }
        }

    }  
}
