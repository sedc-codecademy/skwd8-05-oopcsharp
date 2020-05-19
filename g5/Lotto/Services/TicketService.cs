using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using Models;
using Services.Data;

namespace Services
{
    public class TicketService
    {
        public void CreateNewTicket(string cardNumber, List<int> numbers, float pay)
        {
            User user = DataHelper.Users.FirstOrDefault(x => x.CardNumber == cardNumber);

            if (user == null)
            {
                throw new Exception($"The user with card number {cardNumber}, does not exist.");
            }

            if (user.Balance < pay)
            {
                throw new Exception("User does not have enough money.");
            }

            numbers = numbers.Distinct().ToList();

            if (numbers.Count != 7)
            {
                throw new Exception("Ticket is not populate correctly.");
            }

            if (numbers.Any(x => x < 1 || x > 37))
            {
                throw new Exception("Invalid number, this is lotto 1-37.");
            }

            int activeRoundNumber = DataHelper.LottoOrganization.Rounds.Select(x => x.RoundNumber).Max();

            Round activeRound =
                DataHelper.LottoOrganization.Rounds.Single(x => x.RoundNumber == activeRoundNumber);

            activeRound.Tickets.Add(new Ticket(numbers, pay, user.Id, activeRoundNumber));
            user.Balance -= pay;
        }
    }
}
