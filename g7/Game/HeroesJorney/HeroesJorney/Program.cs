using System;

namespace HeroesJorney
{
	class Program
	{
		static void Main(string[] args)
		{
            bool isLoggedIn = false;
            while (true)
            {
                #region Log In
                string[] emails = { "bob22@mail.com", "jill24@gmail.com" };
                string[] passwords = { "bobbest", "jillbest" };
                int loginAttempts = 0;
                bool exit = false;
                while (true)
                {
                    if (isLoggedIn) break;
                    if (loginAttempts == 5)
                    {
                        Console.WriteLine("You tried too many times! Press enter to exit...");
                        Console.ReadLine();
                        exit = true;
                        break;
                    }
                    loginAttempts++;
                    Console.Clear();
                    Console.Write("Enter email: ");
                    string email = Console.ReadLine();
                    Console.Write("Enter password: ");
                    string password = Console.ReadLine();
                    if (email == "" || password == "")
                    {
                        Console.WriteLine("Don't leave email or password empty! Press enter to try again...");
                        Console.ReadLine();
                        continue;
                    }
                    if (!email.Contains("@") || !email.Contains("."))
                    {
                        Console.WriteLine("Email is not valid. Press enter to try again...");
                        Console.ReadLine();
                        continue;
                    }
                    for (int i = 0; i < emails.Length; i++)
                    {
                        if (emails[i] == email && passwords[i] == password)
                        {
                            Console.WriteLine("Welcome " + email + "!");
                            isLoggedIn = true;
                            break;
                        }
                    }
                    if (isLoggedIn) break;
                    Console.WriteLine("Email or password did not match. Press enter to try again...");
                    Console.ReadLine();
                    continue;
                }
                if (exit) break;
                #endregion
                #region Character Creation
                Console.WriteLine("Press Enter to start with character creation...");
                Console.ReadLine();
                Console.Clear();
                string heroName = "";
                string heroRace = "";
                string heroClass = "";
                int heroHealth = 0;
                int heroStrength = 0;
                int heroAgility = 0;
                while (true)
                {
                    Console.Clear();
                    Console.Write("Choose a name:");
                    heroName = Console.ReadLine();
                    if (heroName.Length < 2 || heroName.Length > 20)
                    {
                        Console.WriteLine("Hero name must be from 2 to 20 characters long. Press enter to try again...");
                        Console.ReadLine();
                        continue;
                    }
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("Choose a race:");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("1) Dwarf");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("2) Elf");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("3) Human");
                        Console.ResetColor();
                        int answer = 0;
                        bool answerCorrect = int.TryParse(Console.ReadLine(), out answer);
                        if (!answerCorrect)
                        {
                            Console.WriteLine("Please enter a valid number from the options. Press enter and try again...");
                            Console.ReadLine();
                            continue;
                        }
                        if (answer < 1 || answer > 3)
                        {
                            Console.WriteLine("Please enter a valid number from the options. Press enter and try again...");
                            Console.ReadLine();
                            continue;
                        }
                        switch (answer)
                        {
                            case 1:
                                heroRace = "Dwarf";
                                heroHealth = 100;
                                heroStrength = 6;
                                heroAgility = 2;
                                break;
                            case 2:
                                heroRace = "Elf";
                                heroHealth = 60;
                                heroStrength = 4;
                                heroAgility = 6;
                                break;
                            case 3:
                                heroRace = "Human";
                                heroHealth = 80;
                                heroStrength = 5;
                                heroAgility = 4;
                                break;
                        }
                        break;
                    }
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("Choose a class:");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("1) Warrior");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("2) Rogue");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("3) Mage");
                        Console.ResetColor();
                        int answer = 0;
                        bool answerCorrect = int.TryParse(Console.ReadLine(), out answer);
                        if (!answerCorrect)
                        {
                            Console.WriteLine("Please enter a valid number from the options. Press enter and try again...");
                            Console.ReadLine();
                            continue;
                        }
                        if (answer < 1 || answer > 3)
                        {
                            Console.WriteLine("Please enter a valid number from the options. Press enter and try again...");
                            Console.ReadLine();
                            continue;
                        }
                        switch (answer)
                        {
                            case 1:
                                heroClass = "Warrior";
                                heroHealth += 20;
                                heroAgility -= 1;
                                break;
                            case 2:
                                heroClass = "Rogue";
                                heroHealth -= 20;
                                heroAgility += 1;
                                break;
                            case 3:
                                heroClass = "Mage";
                                heroHealth += 20;
                                heroStrength -= 1;
                                break;
                        }
                        break;
                    }
                    Console.WriteLine("Character successfully created!");
                    Console.WriteLine(heroName + "(" + heroRace + ") " + "the " + heroClass);
                    Console.WriteLine("Status: " + heroHealth + " HP, " + heroStrength + " STR, " + heroAgility + " AGI");
                    break;
                }

                #endregion
                #region Game Play
                Console.WriteLine("Press Enter to start the game...");
                Console.ReadLine();
                Console.Clear();
                string[] events =
                {
                "Bandits attack you out of nowhere. They seem very dangerous...",
                "You bump in to one of the guards of the nearby village. They attack you without warning...",
                "A Land Shark appears. It starts chasing you down to eat you...",
                "You accidentally step on a rat. His friends are not happy. They attack... ",
                "You find a huge rock. It comes alive somehow and tries to smash you..."
                };
                int[] eventHealthModifiers = { 20, 30, 50, 10, 30 };
                for (int i = 0; i < events.Length; i++)
                {
                    Console.Clear();
                    while (true)
                    {
                        Console.WriteLine(events[i]);
                        Console.WriteLine("Health: " + heroHealth);
                        Console.WriteLine("1) Fight");
                        Console.WriteLine("2) Run");
                        int answer = 0;
                        bool answerCorrect = int.TryParse(Console.ReadLine(), out answer);
                        if (!answerCorrect)
                        {
                            Console.WriteLine("Please enter a valid number from the options. Press enter and try again...");
                            Console.ReadLine();
                            Console.Clear();
                            continue;
                        }
                        if (answer < 1 || answer > 2)
                        {
                            Console.WriteLine("Please enter a valid number from the options. Press enter and try again...");
                            Console.ReadLine();
                            Console.Clear();
                            continue;
                        }
                        if (answer == 1)
                        {
                            if (new Random().Next(11) < heroStrength)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("You won the fight!");
                                Console.ResetColor();
                                Console.WriteLine("Press enter to continue...");
                                Console.ReadLine();
                                break;
                            }
                            else
                            {
                                heroHealth -= eventHealthModifiers[i];
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("You lost the fight!");
                                Console.ResetColor();
                                Console.WriteLine("Press enter to continue...");
                                Console.ReadLine();
                                break;
                            }
                        }
                        if (answer == 2)
                        {
                            if (new Random().Next(11) < heroAgility)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("You ran away!");
                                Console.ResetColor();
                                Console.WriteLine("Press enter to continue...");
                                Console.ReadLine();
                                break;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                heroHealth -= eventHealthModifiers[i];
                                Console.WriteLine("You didn't manage to run away!");
                                Console.ResetColor();
                                Console.WriteLine("Press enter to continue...");
                                Console.ReadLine();
                                break;
                            }
                        }
                    }
                    if (heroHealth <= 0) break;
                }
                Console.Clear();
                if (heroHealth <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You Lost!");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You Won!");
                    Console.ResetColor();
                }
                Console.WriteLine("Want to play again?");
                Console.WriteLine("1) Yes");
                Console.WriteLine("2) No");
                int playAgain = 0;
                bool playAgainCorrect = int.TryParse(Console.ReadLine(), out playAgain);
                if (!playAgainCorrect)
                {
                    Console.WriteLine("Please enter a valid number from the options. Press enter and try again...");
                    Console.ReadLine();
                    continue;
                }
                if (playAgain < 1 || playAgain > 2)
                {
                    Console.WriteLine("Please enter a valid number from the options. Press enter and try again...");
                    Console.ReadLine();
                    continue;
                }
                Console.Clear();
                if (playAgain == 2) break;
                #endregion
            }
            Console.WriteLine("Thank you for playing. Press Enter to exit and have a nice day!");
            Console.ReadLine();
        }
	}
}
