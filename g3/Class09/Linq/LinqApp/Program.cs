using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace LinqApp
{
    enum Breed
    {
        Bulldog,
        Pudlica,
        Labrador
    }

    class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Breed Breed { get; set; }
    }

    class Program
    {
        static void PrintCollection(List<Dog> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine($"{item.Name} {item.Age} {item.Breed}");
            }
        }

        static void PrintDog(Dog dog)
        {
            if (dog != null)
                Console.WriteLine($"{dog.Name} {dog.Age} {dog.Breed}");
            else
                Console.WriteLine("dog is null");
        }

        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>()
            {
                new Dog(){Name = "Sparky", Age = 2, Breed = Breed.Bulldog},
                //new Dog(){Name = "Sparky", Age = 6, Breed = Breed.Pudlica},
                new Dog(){Name = "Butch", Age = 1, Breed = Breed.Labrador},
                new Dog(){Name = "Zoe", Age = 3, Breed = Breed.Pudlica},
                new Dog(){Name = "Sia", Age = 1, Breed = Breed.Labrador},
                new Dog(){Name = "William", Age = 4, Breed = Breed.Labrador},
                new Dog(){Name = "Billy", Age = 5, Breed = Breed.Bulldog},
                new Dog(){Name = "Billy", Age = 1, Breed = Breed.Pudlica},
                new Dog(){Name = "Buck", Age = 2, Breed = Breed.Pudlica},
                new Dog(){Name = "Willy", Age = 4, Breed = Breed.Pudlica},
                new Dog(){Name = "Tom", Age = 2, Breed = Breed.Bulldog}
            };


            //Console.WriteLine(dogs[1].Name);
            //Console.WriteLine(dogs.ElementAt(1).Name);

            ////dogs.filter(x => x.age === 1); // This is how it's done in JS
            List<Dog> dogsWithAgeOne = dogs.Where(dog => dog.Age == 1).ToList(); // Filters all elements and returns only the ones that have Age = 1
            //PrintCollection(dogsWithAgeOne);

            Dog sparky1 = dogs.Single(d => d.Name == "Sparky"); // Checks if only 1 (not 0, not more than 1) element in the Collection exists, otherwise it throws an Exception
            //PrintDog(sparky1);

            //dogs[0]
            Dog sparky2 = dogs.First(); // Return the first element in a collection
            //PrintDog(sparky2);

            Dog billy1 = dogs.First(d => d.Name == "Billy"); // Returns the first element that have a name "Billy", if there is no element named "Billy" throws an Exception
            //PrintDog(billy);

            Dog tom1 = dogs.FirstOrDefault(d => d.Name == "Tom"); // Returns the first element that have a name "Tom", if there is no element named "Tom" return null, it doesn't throw an Exception
            //PrintDog(tom);

            //dogs[dogs.Count - 1]
            Dog tom2 = dogs.Last(); // Returns the last element of the collection
            //PrintDog(tom2);

            Dog bully2 = dogs.Last(d => d.Name == "Billy"); // Same as .First(), but for the last element
            //PrintDog(bully2);

            Dog oldDog = dogs.LastOrDefault(d => d.Age > 20); // Same as .FirstOrDefault, but for the last element
            //PrintDog(oldDog);



            //dogs.map(p => p.name); // This is how it's done in JS
            List<string> dogNames = dogs.Select(d => d.Name).ToList(); // Selects only the "Name" property of each element, and returns a List<string> since the type of "Name" is string
            List<int> dogAges = dogs.Select(d => d.Age).ToList(); // Selects only the "Age" property of each element, and returns a List<int> since the type of "Age" is int
            List<Breed> dogBreeds = dogs.Select(d => d.Breed).ToList(); // Selects only the "Breed" property of each element, and returns a List<Breed> since the type of "Breed" is Breed(enum)

            //dogs.sort((d1, d2) => d2.age - d1.age); // This is how it's done in JS
            List<Dog> dogsByAgeAsc = dogs.OrderBy(d => d.Age).ToList(); // Sorts the collection by the values of Age property (.OrderBy() sorts by Ascending)
            //PrintCollection(dogsByAgeAsc);
            //Console.WriteLine("------------------------");

            List<Dog> dogsByNameAsc = dogs
                                        .OrderBy(d => d.Name)
                                        .ThenByDescending(d => d.Age)
                                        .ToList(); // Sorts the collection by the values of "Name" property. If it finds two or more same names, THEN it will sort those elements by "Age"
            //PrintCollection(dogsByNameAsc);
            //Console.WriteLine("------------------------");

            List<Dog> dogsByAgeDesc = dogs.OrderByDescending(d => d.Age).ToList(); // Sorts the collection by the values of Age property (.OrderByDescending() sorts by Descending)
            //PrintCollection(dogsByAgeDesc);
            //Console.WriteLine("------------------------");

            List<Dog> dogsByNameDesc = dogs.OrderByDescending(d => d.Name).ToList(); // Sorts the collection by the values of Name property alphabetically since Name is string (.OrderByDescending() sorts by Descending)
            //PrintCollection(dogsByNameDesc);
            //Console.WriteLine("------------------------");



            Console.ReadLine();
        }
    }
}
