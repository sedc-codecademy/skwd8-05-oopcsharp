using System;

namespace Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            // empty DateTime
            DateTime emptyDate = new DateTime();
            //Console.WriteLine(emptyDate);

            DateTime customDate = new DateTime(2020, 3, 27);
            //Console.WriteLine(customDate);

            string stringDate1 = "03-27-2020";
            string stringDate2 = "03.27.2020";
            string stringDate3 = "03/27/2020";
            string stringDate4 = "03/27/20";
            string stringDate5 = "mar.27.2020";
            string stringDate6 = "march.27.2020";

            // invalid format 
            // date time format depends on your windows system settings
            //string stringDate7 = "23-03-2020";
            DateTime convertedDate = DateTime.Parse(stringDate6);
            // Console.WriteLine(convertedDate);

            // Current day with time
            DateTime currentDate = DateTime.Now;
            //Console.WriteLine(currentDate);

            // Current day with default time
            DateTime currentDay = DateTime.Today;
            //Console.WriteLine(currentDay);

            // to add days/months/years
            DateTime adddedDays = currentDate.AddDays(3);
            DateTime adddedMonths = currentDate.AddMonths(3);
            DateTime adddedYears = currentDate.AddYears(3);

            //Console.WriteLine(adddedDays);
            //Console.WriteLine(adddedMonths);
            //Console.WriteLine(adddedYears);

            // to remove days/months/years use same methods with -
            DateTime removedDays = currentDate.AddDays(-5);
            //Console.WriteLine(removedDays);

            // type DayOfWeek returns day of week
            DayOfWeek dayOfWeek = currentDate.DayOfWeek;
            //Console.WriteLine(dayOfWeek);

            // Formatting date time
            string dateFormat1 = currentDate.ToString("MM/dd/yyyy");
            string dateFormat2 = currentDate.ToString("dddd, dd MM yyyy");
            string dateFormat3 = string.Format("Today is {0:MM/dd/yyyy}, {0:dddd}", currentDate);
            string dateFormat4 = string.Format("Today is {0:dd-MMMM-yyyy}, {0:t}", currentDate);

            //Console.WriteLine(dateFormat1);
            //Console.WriteLine(dateFormat2);
            //Console.WriteLine(dateFormat3);
            //Console.WriteLine(dateFormat4);


            Console.ReadLine();
        }
    }
}
