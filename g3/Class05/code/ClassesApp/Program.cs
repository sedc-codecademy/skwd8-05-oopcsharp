using System;

namespace ClassesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Animal("Jack", "Bower", 21, "Pudlica", 123456, 654321, 10000);
            Animal cat = new Animal();
            Animal mouse = new Animal("Jerry", "Gruevski", 16);
            dog.Eat("apple");
            Console.WriteLine(dog.Name);
            Console.WriteLine(dog.LastName);
            Console.WriteLine($"You just widrawaled: {dog.Widrawal(100, 123321)}");
            //dog.Widrawal(100, 56524256);

            Console.Read();
        }
    }

    class Animal
    {
        public Animal(string name, string lastName, int age, string breed, int anNLB, int anHALK, int money)
        {
            Console.WriteLine($"Constructing an object {name}");
            Name = name;
            LastName = lastName;
            Age = age;
            Breed = breed;
            AccountNumberNLB = anNLB;
            AccountNumberHALK = anHALK;
            Money = money;
        }

        public Animal(string name, string lastName, int age)
        {
            Console.WriteLine($"Constructing an partial object {name}");
            Name = name;
            LastName = lastName;
            Age = age;
        }

        public Animal()
        {
            Console.WriteLine($"Constructing an empty Animal object");
        }

        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }
        private int AccountNumberNLB { get; set; }
        private int AccountNumberHALK { get; set; }
        private int Money { get; set; }

        public void Eat(string food)
        {
            Console.WriteLine($"Eeating {food}");
        }

        private int CheckMoney(int money)
        {
            if (Money > money)
            {
                Money -= money;
                return money;
            }
            else
            {
                Console.WriteLine("You don't have that much money");
                return 0;
            }
        }

        public int Widrawal(int money, int accountNum)
        {
            if (accountNum == AccountNumberHALK)
            {
                return CheckMoney(money);
            }
            else if (accountNum == AccountNumberNLB)
            {
                return CheckMoney(money);
            }
            else
            {
                Console.WriteLine("You don't have that account");
                return 0;
            }
        }
    }

    
}
