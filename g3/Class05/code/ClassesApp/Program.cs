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
            Console.WriteLine(dog.Name); // This works because Name property is a public property, and it can be used with an object constructed from Animal class
            Console.WriteLine(dog.LastName);
            //Console.WriteLine(dog.Money); // This does not work, because Money is a private property, it can only be accessed inside the Animal class
            Console.WriteLine($"You just widrawaled: {dog.Withdrawal(100, 123321)}");

            Console.Read();
        }
    }

    class Animal
    {
        // This is the constructor of a class, it's almost the same as any other methods, the only difference is that we don't write any return type not even void, and is very similar to a constructor function as in JavaScript
        public Animal() // If we don't write any constructor, an empty constructor like this one is automatically added by default
        {
            //Console.WriteLine($"Constructing an empty Animal object");
        }

        // We use constructors for constructing an object, we can have multiple constructors, and we can construct objects using any of the construcotrs
        public Animal(string name, string lastName, int age)
        {
            Console.WriteLine($"Constructing an partial object {name}"); // A simple console message when we will call particularly this constructor
            Name = name;
            LastName = lastName;
            Age = age;
        }

        // A third way of constructing an object
        public Animal(string name, string lastName, int age, string breed, int anNLB, int anHALK, int money)
        {
            Console.WriteLine($"Constructing an object {name}"); // Another simple message when we call this constructor
            Name = name; // "Name" is the property that is defined in this class below, and "name" is the parameter of the constructor
            LastName = lastName; // The same as above
            Age = age;
            Breed = breed;
            AccountNumberNLB = anNLB;
            AccountNumberHALK = anHALK;
            Money = money;
        }

        public string Name { get; set; } // Public properties like "Name" here, can be used(accessed) inside and outside of Animal class, the outside way is by constructing an object from Animal class, see the references in the Main method
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }
        private int AccountNumberNLB { get; set; } 
        private int AccountNumberHALK { get; set; }
        private int Money { get; set; } // Private properties like Money can be used or accessed only inside the Animal class.

        public void Eat(string food)
        {
            Console.WriteLine($"Eeating {food}");
        }

        // Private methods like "CheckMoney" can be called only inside the Animal class
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

        // Public methods like "Withdrawal" can be called inside and outside of Animal class. The outside way is by constructing an object from Animal class, that's why they are public
        public int Withdrawal(int money, int accountNum)
        {
            if (accountNum == AccountNumberHALK)
            {
                return CheckMoney(money); // We can call the private method CheckMoney in here, because Withdrawal's method definition is the same scope as CheckMoney and they are both inside the class Animal
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
