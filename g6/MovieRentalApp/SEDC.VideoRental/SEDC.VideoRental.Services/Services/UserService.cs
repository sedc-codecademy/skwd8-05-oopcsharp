using SEDC.VideoRental.Data.Database;
using SEDC.VideoRental.Data.Models;
using SEDC.VideoRental.Services.Helpers;
using SEDC.VideoRental.Services.Loaders;
using System;
using System.Threading;

namespace SEDC.VideoRental.Services.Services
{
    public class UserService
    {
        private UserRepository _userRepository;

        public UserService()
        {
            _userRepository = new UserRepository();
        }

        public User Login()
        {
            while (true)
            {
                Console.Write("Enter card id number: ");
                var idCard = InputParser.ToInteger(100, 999);

                var user = _userRepository.GetUserByIdCard(idCard);
                LoadingHelpers.Spiner();

                if(user != null)
                {
                    Console.WriteLine($"Welcome {user.FullName}");
                    return user;
                }
                Console.WriteLine("User card id does not exists.");
                Console.WriteLine("Try again y/n");
                if (!InputParser.ToConfirm())
                {
                    Console.WriteLine("Thank you for using rent a video app.");
                    Thread.Sleep(3000);
                    Environment.Exit(0);
                }
            }
        }

        public User SignUp()
        {
            while (true)
            {
                Console.Write("Enter full name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter date of birth");
                DateTime dob = InputParser.ToDateTime();
                int cardNumber = GenerateNewCardNumber();

                Console.WriteLine("Creating user please wait...");
                LoadingHelpers.ShowSimplePercentage();

                var user = new User
                {
                    CardNumber = cardNumber,
                    FullName = name,
                    DateOfBirth = dob
                };
                Console.WriteLine($"\rWelcome {user.FullName} Card number: {user.CardNumber}");
                return user;
            }
        }

        private int GenerateNewCardNumber()
        {
            const int max = 1000;
            const int min = 100;
            var rand = new Random();
            var takenCardNumbers = _userRepository.GetAllCardNumbers();

            int cardNumber;
            do
            {
                cardNumber = rand.Next(min, max);
            }
            while (takenCardNumbers.Contains(cardNumber));
            return cardNumber;
        }
    }
}
