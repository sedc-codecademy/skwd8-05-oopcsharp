using System;
using System.Collections.Generic;
using System.Text;

namespace Lotary.Helpers
{
    public class LottaryHelpers
    {
        public static int CheckTicket(int[] winningCombination, int[] ticketNumbers)
        {
            int count = 0;
            foreach (var number in winningCombination)
            {
                foreach (var num in ticketNumbers)
                {
                    if (number == num)
                    {
                        count++;
                    }
                }

            }
            return count;
        }
    }
}
