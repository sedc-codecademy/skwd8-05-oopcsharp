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


            //Console.WriteLine(dogs[1]);
            //Console.WriteLine(dogs.ElementAt(1).Name);

            ////dogs.filter(x => x.age === 1); // This is how it's done in JS
            List<Dog> dogsWithAgeOne = dogs.Where(dog => dog.Age == 1).ToList();
            //PrintCollection(dogsWithAgeOne);

            Dog sparky1 = dogs.Single(d => d.Name == "Sparky");
            //PrintDog(sparky1);

            Dog sparky2 = dogs.First();
            //PrintDog(sparky2);

            Dog billy1 = dogs.First(d => d.Name == "Billy");
            //PrintDog(billy);

            Dog tom1 = dogs.FirstOrDefault(d => d.Name == "Tom");
            //PrintDog(tom);

            //dogs[dogs.Count - 1]
            Dog tom2 = dogs.Last();
            //PrintDog(tom2);

            Dog bully2 = dogs.Last(d => d.Name == "Billy");
            //PrintDog(bully2);

            Dog oldDog = dogs.LastOrDefault(d => d.Age > 20);
            //PrintDog(oldDog);


            //dogs.map(p => p.name)
            List<string> dogNames = dogs.Select(d => d.Name).ToList();
            List<int> dogAges = dogs.Select(d => d.Age).ToList();
            List<Breed> dogBreeds = dogs.Select(d => d.Breed).ToList();

            //dogs.sort((d1, d2) => d2.age - d1.age )
            List<Dog> dogsByAgeAsc = dogs.OrderBy(d => d.Age).ToList();
            PrintCollection(dogsByAgeAsc);
            Console.WriteLine("------------------------");

            List<Dog> dogsByNameAsc = dogs
                                        .OrderBy(d => d.Name)
                                        .ThenByDescending(d => d.Age)
                                        .ToList();
            PrintCollection(dogsByNameAsc);
            Console.WriteLine("------------------------");

            List<Dog> dogsByAgeDesc = dogs.OrderByDescending(d => d.Age).ToList();
            PrintCollection(dogsByAgeDesc);
            Console.WriteLine("------------------------");

            List<Dog> dogsByNameDesc = dogs.OrderByDescending(d => d.Name).ToList();
            PrintCollection(dogsByNameDesc);
            Console.WriteLine("------------------------");




            Console.ReadLine();
        }
    }
}
