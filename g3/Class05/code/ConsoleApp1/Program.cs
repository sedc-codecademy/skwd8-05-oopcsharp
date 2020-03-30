using System;

namespace ConsoleApp1
{
    class Program
    {
        // An Example method
        static int Dejan(string num1, int num2)
        {
            return 5;
        }

        static void Main(string[] args)
        {

            #region DateTime
            //"12/3/2010"
            //"12.3.2010"
            //"3/12/2010"
            //"03/12/10"
            Dejan("2", 3);

            DateTime currentDateTime = DateTime.Now;
            DateTime currentDay = DateTime.Today;
            DateTime myBirthday = new DateTime(1996, 1, 10);
            Console.WriteLine(myBirthday.AddDays(1));
            Console.WriteLine(myBirthday.AddMonths(2));
            Console.WriteLine(myBirthday.AddMinutes(66));
            Console.WriteLine(myBirthday.AddMonths(-3));

            Console.WriteLine(currentDateTime.ToString("MM/dd/yy")); // Custom format for date and time object
            Console.WriteLine(currentDateTime.Year);
            Console.WriteLine(currentDateTime.Day);
            Console.WriteLine(currentDateTime.Month);
            Console.WriteLine(currentDateTime.ToString("yyyy/MMM/d/h/tt")); // Date and time with AM/PM format

            //DateTime newMyBirthday = myBirthday.AddDays(1);
            #endregion

            #region Excercise 1
            Console.WriteLine("Enter your birthday");
            Console.WriteLine("Enter the year");
            string yearInput = Console.ReadLine();
            Console.WriteLine("Enter the month");
            string monthInput = Console.ReadLine();
            Console.WriteLine("Enter the day");
            string dayInput = Console.ReadLine();

            int year = int.Parse(yearInput);
            int month = int.Parse(monthInput);
            int day = int.Parse(dayInput);

            DateTime birthday = new DateTime(year, month, day);
            Console.WriteLine(CaluclateAge(birthday));

            #endregion

            Console.Read();
        }

        static int CaluclateAge(DateTime birthday) // This methods takes 1 parameter and it's type is DateTime, so when we call it we must send a DateTime object
        {
            DateTime rightNow = DateTime.Now;
            int age = rightNow.Year - birthday.Year;
            if (rightNow.Month < birthday.Month ||
                (rightNow.Month == birthday.Month && rightNow.Day < birthday.Day))
                age--;

            return age;
        }
    }
}
