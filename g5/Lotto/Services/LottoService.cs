using System;
using System.Collections.Generic;
using System.Linq;
using Models;
using Services.Data;

namespace Services
{
    public class LottoService
    {
        public void CreateNewLottoOrganization(string name)
        {
            Lotto newOrganization = new Lotto(name);
            DataHelper.LottoOrganization = newOrganization;
        }

        public void Draw()
        {
            List<int> winingNumbers = GenerateRandomNumbers();

            int activeRoundNumber = DataHelper.LottoOrganization.Rounds.Select(x => x.RoundNumber).Max();
            Round activeRound = DataHelper.LottoOrganization.Rounds.Single(x => x.RoundNumber == activeRoundNumber);

            activeRound.WiningNumbers = winingNumbers;

            //Check for wining tickets
            foreach (var ticket in activeRound.Tickets)
            {
                #region Step by step check
                //int correctNumber = 0;

                //foreach (int number in ticket.Numbers)
                //{
                //    if (winingNumbers.Contains(number))
                //        correctNumber++;
                //}

                //if (correctNumber == 4)
                //{
                //    ticket.Status = TicketStatus.Win4;
                //    //calculate price
                //}
                //else if(correctNumber == 5)
                //{
                //    ticket.Status = TicketStatus.Win5;
                //    //calculate price
                //}
                //else if (correctNumber == 6)
                //{
                //    ticket.Status = TicketStatus.Win6;
                //    //calculate price
                //}
                //else if (correctNumber == 7)
                //{
                //    ticket.Status = TicketStatus.Win7;
                //    //calculate price
                //}
                //else
                //{
                //    ticket.Status = TicketStatus.Lost;
                //}
                #endregion

                List<int> correctlyGuessNumbers = winingNumbers.Intersect(ticket.Numbers).ToList();

                if (correctlyGuessNumbers.Count < 4)
                {
                    ticket.Status = TicketStatus.Lost;
                }
                else
                {
                    ticket.Status = (TicketStatus) correctlyGuessNumbers.Count;
                    //TODO: Calculate price
                }
            }
        }

        private List<int> GenerateRandomNumbers()
        {
            List<int> numbers = new List<int>();
            Random rnd = new Random();

            for (int i = 0; i < 7; i++)
            {
                //TODO: Check if rnd.Next gets upper bound
                int rndNumber = rnd.Next(1, 37);

                if (numbers.Any(x => x == rndNumber))
                {
                    i--;
                    continue;
                }

                numbers.Add(rndNumber);
            }

            return numbers;
        }
    }
}
