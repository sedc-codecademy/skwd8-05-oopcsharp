using System;

namespace Exrcise3Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FirstApproach
            string str = "we want this situation with covid-19 to ends!!!!";
            char[] toChar = str.ToCharArray();
            int[] times = new int[toChar.Length];

            for (int i = 0; i < toChar.Length; i++)
            {
                int time = 0;
                for (int j = i; j < toChar.Length; j++)
                {
                    if (toChar[i] == toChar[j] && !Char.IsWhiteSpace(toChar[i]))
                        time++;
                }
                times[i] = time;
            }
            int max = 0;
            int maxTimes = 0;
            for (int i = 0; i < times.Length; i++)
            {
                if (times[i] > maxTimes)
                {
                    max = Array.IndexOf(times, times[i]);
                    maxTimes = times[i];
                }

            }

            Console.WriteLine($"{toChar[max]} times: {maxTimes} ");
            #endregion

            #region Second Approach
            string task3 = "We want this situation with covid-19 to ends!";

            char[] cArray3 = task3.ToUpper().ToCharArray();
            int finalCount = 0;
            int count3 = 0;
            char Mychar = ' ';

            for (int i = 0; i < cArray3.Length; i++)
            {
                count3 = 1;
                for (int j = i + 1; j < cArray3.Length; j++)
                {
                    if (cArray3[i] == cArray3[j] && cArray3[i] != ' ')
                    {
                        count3++;
                        if (count3 >= finalCount)
                        {
                            finalCount = count3;
                            Mychar = cArray3[j];
                        }
                    }
                }
            }
            Console.WriteLine($"The highest frequency of character {Mychar}, appears number of times: {finalCount}");
            #endregion

            #region Third Approach
            string korona = "We want this situation with covid-19 to ends!";
            char[] array = korona.ToCharArray();

            string maxChar = "";
            int maxCount = 0;

            foreach (var letter in array)
            {
                int currentCounter = 0;
                if (!Char.IsWhiteSpace(letter))
                {
                    foreach (var currentLetter in array)
                    {
                        if (letter == currentLetter)
                        {
                            currentCounter++;
                        }
                    }

                    if (currentCounter > maxCount)
                    {
                        maxChar = letter.ToString();
                        maxCount = currentCounter;
                    }
                }
            }

            Console.WriteLine("The highest frequency of character {0} appears number of times : {1} ", maxChar, maxCount);
            #endregion
        }
    }
}
