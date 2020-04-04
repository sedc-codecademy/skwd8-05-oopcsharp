using System;
using System.Linq;
using SEDC.ClassesPart_1.Models;

namespace SEDC.ClassesPart_1
{
    //Class declaration

    // Class = DATA + BEHAVIOUR
    class Person
    {
        //Properties
        public string FirstName;
        public string LastName;
        public DateTime DateOfBirth;

        private int Age;

        //Default constructor
        public Person()
        {

        }

        //Methods
        public void Introuduce()
        {
            HowOld(DateTime.Now);
            Console.WriteLine($"Hello, my name is {FirstName} {LastName} and I am {Age} years old!");
        }
        private void HowOld(DateTime today)
        {
            if(today.Month < DateOfBirth.Month)
            {
                Age = today.Year - DateOfBirth.Year - 1;
            }
            else
            {
                Age = today.Year - DateOfBirth.Year;
            }
        }

        //Get and set private property from outside the class
        public void setAge(int age)
        {
            Age = age;
        }
        public int getAge()
        {
            return Age;
        }
    }


    class Program
    {
        public static void Exercise1()
        {
            // Example 1
            Console.WriteLine("Please enter your first name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Please enter your date of birth in a format dd/MM/yyyy"); // 8/27/1993
            string dateOfBirth = Console.ReadLine();

            //string[] dateSplited = dateOfBirth.Split("/"); //  8 / 27 / 1993
            //DateTime dateOfBirthdParsed = new DateTime(Convert.ToInt32(dateSplited[2]),
            //                                            Convert.ToInt32(dateSplited[1]),
            //                                            Convert.ToInt32(dateSplited[0]));

            DateTime dateOfBirthParsed = DateTime.Parse(dateOfBirth);

            Person person1 = new Person();
            person1.FirstName = firstName;
            person1.LastName = lastName;
            person1.DateOfBirth = dateOfBirthParsed;

            person1.Introuduce();
        }

        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Martin";
            person.LastName = "Panovski";
            person.DateOfBirth = new DateTime(1993, 8, 27);

            //Not accessible property from outside the class, because of the access modifier (private)
            //person.Age = 26;

            //Set and Get private propery by using public method
            //person.setAge(26);
            //Console.WriteLine(person.getAge());

            //What happens if we try to print the whole object => we get SEDC.ClassesPart_1.Person in the console
            //Console.WriteLine(person);

            //Console.WriteLine(person.FirstName);
            //Console.WriteLine(person.LastName);

            //Not accessible property (private)
            //Console.WriteLine(person.Age);

            //person.Introuduce();

            //Exercise1();


            //Using class from different folder, outside Program.cs
            //Need to add using at the top of the workspace, so that we can use the Dog class here
            Dog backy = new Dog();
            backy.Name = "Backy";
            backy.Sort = "Pit bull";
            backy.Color = "black";

            backy.Bark();

            Dog boem = new Dog();
            boem.Name = "Boem";
            boem.Sort = "Golden Retriver";
            boem.Color = "brown";

            
            //The objects instantiated from a class are actualy the type of that class
            //Here is an example how we can declare an array of objects
            //But not any object, just objects that are from type Dog, or instances of the Dog class
            Dog[] dogs = new Dog[] { backy, boem };
            foreach (Dog dog in dogs)
            {
                Console.WriteLine(dog.Name);
            }

            Console.ReadLine();
        }
    }
}
