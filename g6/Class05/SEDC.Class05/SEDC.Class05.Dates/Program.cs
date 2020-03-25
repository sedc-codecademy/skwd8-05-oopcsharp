using System;

namespace SEDC.Class05.Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            // this gives an empty DateTime
            DateTime date = new DateTime();
            Console.WriteLine(date);

            // custom DateTime
            DateTime customDate = new DateTime(1990, 6, 3);
            Console.WriteLine(customDate);

            // valid string format for DateTime
            string stringDate = "03.25.2020";
            string stringDate2 = "03/25/2020 14:32:55";
            string stringDate3 = "03/25/20";
            string stringDate4 = "mar.25.2020";
            string stringDate5 = "03-25-2020";

            DateTime convertedDate = DateTime.Parse(stringDate);
            Console.WriteLine(convertedDate);

            DateTime convertedDate2 = DateTime.Parse(stringDate2);
            Console.WriteLine(convertedDate2);

            DateTime currentDate = DateTime.Today;
            Console.WriteLine(currentDate);

            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine(currentDateTime);

            DateTime addedDays = currentDateTime.AddDays(5);
            Console.WriteLine(addedDays);

            DateTime removedDays = currentDateTime.AddDays(-10);
            Console.WriteLine(removedDays);

            DateTime addedHours = currentDateTime.AddHours(20);
            Console.WriteLine(addedHours);

            int day = currentDateTime.Day;
            int month = currentDateTime.Month;
            int year = currentDateTime.Year;

            Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");

            int dayOfYear = currentDateTime.DayOfYear;
            Console.WriteLine(dayOfYear);

            string dateFormat = currentDateTime.ToString("dddd, dd MMMM yyyy");
            string dateFormat2 = currentDateTime.ToString("MM/dd/yyyy");
            string dateFormat3 = string.Format("Today is {0:MM/dd/yy}, {0:dddd}", currentDateTime);
            string dateFormat4 = string.Format("Today is {0:dd-MM-yyyy}, {0:t}", currentDateTime);

            string stringInterpolation = string.Format("Today {0}, Time {1}", currentDate, currentDateTime);
            Console.WriteLine("Today {0}, Time {1}", currentDate, currentDateTime);

            string stringInterpolation2 = $"Today {currentDate}, Time {currentDateTime}";

            Console.WriteLine("{0:C2}", 1000);

            Console.WriteLine(dateFormat);
            Console.WriteLine(dateFormat2);
            Console.WriteLine(dateFormat3);
            Console.WriteLine(dateFormat4);

            Console.ReadLine();
        }
    }
}
