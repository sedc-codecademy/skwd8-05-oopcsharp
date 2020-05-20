using System;

namespace StaticAndMoreErrorTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            HelperService helperService = new HelperService();
            helperService.Print();

            HelperService.TryParse("34");
            Math.Max(4, 4);
            Math.Sqrt(5);

            Movie movie = null;

            if (3 < 2)
            {
                // Visual Studio gives us a warning for unreachable code
                movie = new Movie { Name = "Terminator 2" };
            }

            HelperService.AddNumbers("34", "32", movie);
            HelperService.AddNumbers("34", "3o", movie);
            HelperService.AddNumbers(null, "32", new Movie { Name = "The Terminator" });

            // Overflow
            //int number = 7376473278463284687468764873684638764838746328487236487326473647828763874632432;

            Console.WriteLine("Press any key to continue!");
            Console.ReadKey();
        }
    }
}
