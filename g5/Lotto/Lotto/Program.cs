using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Models;
using Services;
using Services.Data;

namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            LottoService lottoService = new LottoService();
            UserService userService = new UserService();
            TicketService ticketService = new TicketService();

            lottoService.CreateNewLottoOrganization("Lotarija na Makedonija");
            userService.AddNewUser("Risto", "LM0001");
            userService.AddNewUser("Darko", "LM0002");
            userService.AddNewUser("Admin", "admin");

            while (true)
            {
                try
                {
                    Console.WriteLine($"Welcome to {DataHelper.LottoOrganization.Name}!");
                    Console.WriteLine("Please login entering your card number:");
                    string inputCard = Console.ReadLine();

                    User loggedUser = userService.Login(inputCard);

                    Console.WriteLine($"Welcome {loggedUser.Username}!");

                    if (loggedUser.CardNumber == "admin")
                    {
                        AdminProcedure(lottoService);
                    }
                    else
                    {
                        UserProcedure(loggedUser, ticketService);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Thank you!");
                    Console.WriteLine("Log out......");
                    Thread.Sleep(5000);
                    Console.Clear();
                }
            }
        }

        public static void AdminProcedure(LottoService lottoService)
        {
            Console.WriteLine("Please select:");
            Console.WriteLine("1. Start the draw");
            Console.WriteLine("2. List all winners by round");

            string inputChoice = Console.ReadLine();

            if (!int.TryParse(inputChoice, out int choice) || choice < 1 || choice > 2)
            {
                throw new Exception("Invalid choice.");
            }

            if (choice == 1)
            {
                Console.WriteLine("Draw started.");
                Round completedRound = lottoService.Draw();
                PrintRoundDetails(completedRound);
            }
            else
            {
                foreach (var round in DataHelper.LottoOrganization.Rounds.Where(x => x.WiningNumbers.Any())
                    .OrderBy(x => x.RoundNumber))
                {
                    PrintRoundDetails(round);
                }
            }
        }

        public static void UserProcedure(User user, TicketService ticketService)
        {
            Console.WriteLine("Please select:");
            Console.WriteLine("1. Check your balance");
            Console.WriteLine("2. Create a ticket");
            string inputChoice = Console.ReadLine();

            if (!int.TryParse(inputChoice, out int choice) || choice < 1 || choice > 2)
            {
                throw new Exception("Invalid choice.");
            }

            if (choice == 1)
            {
                Console.WriteLine($"Your balance is: {user.Balance}");
                return;
            }

            List<int> numbers = new List<int>();
            Console.WriteLine("Input your numbers:");
            for (int i = 1; i <= 7; i++)
            {
                Console.Write($"Number {i}: ");
                string inputNumber = Console.ReadLine();

                if (!int.TryParse(inputNumber, out int number))
                {
                    throw new Exception("Invalid number.");
                }

                numbers.Add(number);
            }

            Console.WriteLine("Please enter your payment");
            string paymentInput = Console.ReadLine();

            if (!float.TryParse(paymentInput, out float payment))
            {
                throw new Exception("Invalid payment input");
            }

            ticketService.CreateNewTicket(user.CardNumber, numbers, payment);
        }

        public static void PrintRoundDetails(Round round)
        {
            Console.WriteLine($"----------------------- Round {round.RoundNumber} ----------------------");
            Console.WriteLine($"-------------- [{string.Join(", ", round.WiningNumbers.OrderBy(x => x))}] --------------");
            Console.WriteLine($"----------------------- Winners ----------------------------------------");

            foreach (var ticket in round.Tickets.Where(x =>
                x.Status != TicketStatus.InProgress && x.Status != TicketStatus.Lost))
            {
                User user = DataHelper.Users.First(x => x.Id == ticket.UserId);

                Console.WriteLine(
                    $"|{ticket.Id}|{ticket.Date:dd.MM.yyyy HH:mm:ss}|[{string.Join(", ", ticket.Numbers.OrderBy(x => x))}]|{ticket.Payment}|{ticket.Status}|{ticket.Price}|{user.Username}|");
            }
        }
    }
}
