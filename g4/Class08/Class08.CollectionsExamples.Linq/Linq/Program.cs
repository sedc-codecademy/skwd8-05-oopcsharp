using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    public class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {

        static void Main(string[] args)
        {
            // Simple Linq examples
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };

            //// Select 
            //Console.WriteLine("----------- Select ---------------");
            //List<int> addOneToNumbers = numbers
            //                            .Select((num, index) => num + 1)
            //                            .ToList();
            //// even lazier way to loop through all elements
            ////foreach (var item in addOneToNumbers)
            ////{
            ////    Console.WriteLine(item);
            ////}
            //addOneToNumbers.ForEach(x => Console.WriteLine(x));

            //// Where
            //Console.WriteLine("----------- Where ---------------");

            //List<int> greaterThanThree = numbers
            //                            .Where(num => num >= 3)
            //                            .ToList();
            //greaterThanThree.ForEach(x => Console.WriteLine(x));

            //// First
            //Console.WriteLine("----------- First ---------------");

            //int firstElement = greaterThanThree
            //                            .First();
            //Console.WriteLine(firstElement);

            //// Last
            //Console.WriteLine("----------- Last ---------------");

            //int lastElement = greaterThanThree
            //                            .Last();
            //Console.WriteLine(lastElement);

            // More complex examples of linq


            // Data for LINQ manipulation
            List<Dog> dogs = new List<Dog>()
            {
                new Dog(){Name = "Sparky", Age = 2},
                new Dog(){Name = "Butch", Age = 1},
                new Dog(){Name = "Zoe", Age = 3},
                new Dog(){Name = "Sia", Age = 1},
                new Dog(){Name = "William", Age = 4},
                new Dog(){Name = "Billy", Age = 1},
                new Dog(){Name = "Buck", Age = 2}
            };

            // all dogs with name longer than 3
            List<Dog> nameLongerThan3 = dogs
                                           .Where(x => x.Name.Length > 3)
                                           .ToList();
            //nameLongerThan3.ForEach(x => Console.WriteLine(x.Name));

            // All dogs with name starting with S
            List<Dog> nameStartsWithS = dogs
                                            .Where(x => x.Name.StartsWith("S"))
                                            // .Where(x => x.Name.ToCharArray()[0] == 'S')
                                            .ToList();
            //nameStartsWithS.ForEach(x => Console.WriteLine(x.Name));

            // First dog that is of age 1 and has a name that starts with B
            Dog dogAge1NameB = dogs
                                .Where(x => x.Age == 1)
                                .Where(x => x.Name.StartsWith("B"))
                                .First();
            //Console.WriteLine($"Age: {dogAge1NameB.Age}, Name: {dogAge1NameB.Name}");

            Dog dogAge5NameW = dogs
                                .Where(x => x.Age == 5)
                                .Where(x => x.Name.StartsWith("W"))
                                .FirstOrDefault();
            //Console.WriteLine(dogAge5NameW == null ? "No results found!" : dogAge5NameW.Name);

            // All names of dogs
            List<string> namesOfDogs = dogs
                                        .Select(x => x.Name)
                                        .ToList();
            //namesOfDogs.ForEach(x => Console.WriteLine(x));

            // All dogs ages
            List<int> agesOfDogs = dogs
                                    .Select(x => x.Age)
                                    .ToList();
            //agesOfDogs.ForEach(x => Console.WriteLine(x));

            // all names of dogs of age 2
            List<string> namesOfDogsAge2 = dogs
                                            .Where(x => x.Age == 2)
                                            .Select(x => x.Name)
                                            .ToList();

            namesOfDogsAge2.ForEach(Console.WriteLine);


            Console.ReadLine();
        }
    }
}
