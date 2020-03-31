using System;
using System.Globalization;

namespace Exe5
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime customDate = new DateTime(1993, 5, 23);
            DateTime emptyDate = new DateTime();
            DateTime today = DateTime.Today;
            DateTime now = DateTime.Now;

            DateTime minDate = DateTime.MinValue;
            DateTime maxDate = DateTime.MaxValue;
            DateTime utcDate = DateTime.UtcNow;

            Console.WriteLine(now.ToString());
            Console.WriteLine(now.ToString(new CultureInfo("en-US")));
            Console.WriteLine(now.ToString("dd*MM*yyyy"));

            DateTime nowPlusOneYear = now.AddYears(1);
            Console.WriteLine($"This time next year it will be: {nowPlusOneYear.DayOfWeek}");

            DateTime date = new DateTime(2020, 2, 29);
            Console.WriteLine(date.AddYears(4));
        }
    }
}
