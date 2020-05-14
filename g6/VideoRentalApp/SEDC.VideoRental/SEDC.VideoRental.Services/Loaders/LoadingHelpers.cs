using System;
using System.Threading;

namespace SEDC.VideoRental.Services.Loaders
{
    public class LoadingHelpers
    {
        public static void Spiner()
        {
            for (int i = 0; i < 20; i++)
            {
                switch (i % 4)
                {
                    case 0: Console.Write("/"); break;
                    case 1: Console.Write("-"); break;
                    case 2: Console.Write("\\"); break;
                    case 3: Console.Write("|"); break;
                }
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                Thread.Sleep(150);
            }
        }

        public static void ShowSimplePercentage()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.Write($"\rProgress: {i}%   ");

                if (i % 25 == 0)
                {
                    Thread.Sleep(450);
                }
                else
                {
                    Thread.Sleep(55);
                }
            }

            Console.Write("\rDone!          ");
        }
    }
}
