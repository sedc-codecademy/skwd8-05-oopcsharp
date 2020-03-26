using System;

namespace Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating DateTime - empty/initial
            DateTime date = new DateTime();
            Console.WriteLine(date);

            // Creating a custom DateTime - my birthday :)
            var birthday = new DateTime(1989, 5, 15, 3, 5, 12);
            Console.WriteLine(birthday);

            // NO COMPILE TIME ERROR!!!!
            // Broken application :'(
            //var customDate = new DateTime(-1989, 5, 15);

            //DateTime combinations and from STRING conversion
            string date1 = "05/15/89";
            string date2 = "05.15.1989";
            string date3 = "05/15/1989 03:05:12";
            string date4 = "03-26-2020";
            string date5 = "mar.26.2020";

            Console.WriteLine("DATE TIME CONVERSION:");
            DateTime conversionDate3 = DateTime.Parse(date3);
            Console.WriteLine(conversionDate3);

            // GDPR - use another/fake birthday! :/
            // TODAY!!

            var today = DateTime.Now;
            Console.WriteLine(today);

            int day = today.Day;
            int month = today.Month;
            int year = today.Year;

            Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");

            Console.WriteLine("Tomorrow is " + today.AddDays(1));
            Console.WriteLine("Yesterday was " + today.AddDays(-1).AddHours(1));

            // FORMATTING DATES

            string dateFormat = today.ToString("MM/dd/yyyy");
            Console.WriteLine(dateFormat);

            string dateFormatAnother = today.ToString("dddd, dd MMMM yyyy");
            Console.WriteLine(dateFormatAnother);

            // Pay attention on date time format before PARSE
            // Suggestion -> check with today FIRST!

            var check = DateTime.Now;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Format is:" + check);

            string tt = "05/15/2020 03:02:00";
            var n = DateTime.Parse(tt);

            Console.WriteLine(n);
            Console.ReadLine();
        }
    }
}
