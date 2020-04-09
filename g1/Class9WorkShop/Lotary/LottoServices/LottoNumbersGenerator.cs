using System;
using System.Collections.Generic;
using System.Text;

namespace LottoServices
{
    public class LottoNumbersGenerator
    {
        public static int[] GenerateNumbers()
        {
            int[] winningCombination = new int[7];
            for (int i = 0; i < winningCombination.Length; i++)
            {
                int number = new Random().Next(1, 36);
                if (Array.IndexOf(winningCombination, number) != -1)
                {
                    while (Array.IndexOf(winningCombination, number) != -1)
                    {
                        number = new Random().Next(1, 36);
                    }
                }
                winningCombination[i] = number;
            }
            return winningCombination;
        }
    }
}
