using System;

namespace SEDC.MethodsAndStrings
{
    class Program
    {
        // Methods no parameters, no return ( void )
        static void SayMyName()
        {
            Console.WriteLine("Hello my name is Martin!");
        }

        static void SayHello()
        {
            Console.WriteLine("Hello, what a lovely day in quarantine!");
        }

        //Methods with input parameters, no return ( void )
        static void DisplayFullName(string firstName, string lastName)
        {
            Console.WriteLine(firstName + " " + lastName);
        }

        static void RoleCheck(string name)
        {
            if(name == "Martin")
            {
                Console.WriteLine($"{name} is trainer.");
            }else if(name == "Ivo")
            {
                Console.WriteLine($"{name} is assistant.");
            }
            else
            {
                Console.WriteLine($"{name} is student.");
            }
        }

        //Methods with return type
        static string ShowMessage()
        {
            string message = "This is the expected string!";
            return message;
        }

        static int[] GenerateNumbers()
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            return nums;
        }

        //Methods with input parameters and return type
        static int Multiply(int a, int b)
        {
            return a * b;
        }
        static double Division(double a, double b)
        {
            if(b != 0)
            {
                return a / b;
            }
            else
            {
                return 0;
            }
        }

        //Wrapper method for a whole business logic
        static void Calculator()
        {
            Console.WriteLine("Please enter an operation (* or /)");
            string sign = Console.ReadLine();

            while(sign != "*" && sign != "/")
            {
                Console.WriteLine("Please enter an appropriate operation * or /");
                sign = Console.ReadLine();
            }

            Console.WriteLine("Please enter first number: ");
            double firstNum = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the second number: ");
            double secondNum = Convert.ToDouble(Console.ReadLine());

            if(sign == "*")
            {
                Console.WriteLine(Multiply(Convert.ToInt32(firstNum), Convert.ToInt32(secondNum)));
            }
            else if(sign == "/")
            {
                Console.WriteLine(Division(firstNum, secondNum));
            }
        }

        //Method calling a method as a return type
        static int MultiplyResult()
        {
            return Multiply(5, 10);
        }

        static void Main(string[] args)
        {
            SayMyName();
            SayHello();

            DisplayFullName("Ivo", "Kostovski");
            RoleCheck("Irina");
            RoleCheck("Ivo");

            Console.WriteLine(ShowMessage());
            Console.WriteLine(GenerateNumbers());
            Console.WriteLine(Multiply(5, 10));

            Calculator();


            #region Strings Concatenation

            //Concatenating strings
            //World Health Organization - WHO

            string worldHealthOrg = "World Health Organization";
            string worldHealthAbr = "WHO";

            //Simple concatenation
            string worldHealtOrgCon = worldHealthOrg + "-" + worldHealthAbr;
            Console.WriteLine(worldHealtOrgCon);

            //Formating string - PLACEHOLDERS
            Console.WriteLine("{0} - {1}", worldHealthOrg, worldHealthAbr);

            string worldHealthTitle = String.Format("{0} - {1}", worldHealthOrg, worldHealthAbr);
            Console.WriteLine(worldHealthTitle);

            long mobile = 38970223332;
            string phoneNumber = String.Format("{0:(###) ## ###-###}", mobile);
            Console.WriteLine(phoneNumber);

            float price = 150.29f;
            string priceCurrency = String.Format("{0:C}", price);
            Console.WriteLine(priceCurrency);

            float part = 0.5f;
            string percent = String.Format("{0:P}", part);
            Console.WriteLine(percent);
            #endregion


            #region String Methods
            //ToLower() and ToUpper()
            string fullName = "Martin Panovski";

            string fullNameToLower = fullName.ToLower();
            string fullNameToUpper = fullName.ToUpper();

            Console.WriteLine("ToLower - {0} / ToUpper - {1}", fullNameToLower, fullNameToUpper);

            string sedc = "         Seavus Education and Development Center        ";
            Console.WriteLine(sedc.Trim());
            Console.WriteLine(sedc.TrimStart());
            Console.WriteLine(sedc.TrimEnd());


            //String Interpolation
            string sedcLong = "Seavus Education and Development Center";
            string sedcAbr = "SEDC";
            string resultString = $"I am learing web development at {sedcLong} - {sedcAbr}";
            Console.WriteLine(resultString);

            //Length
            string description = "Today was such a sunny and funny day!";
            Console.WriteLine(description.Length);

            foreach (char character in description)
            {
                Console.WriteLine(" " + character);
            }

            int indexOfCharacter = description.IndexOf("a");
            Console.WriteLine(indexOfCharacter);

            //Substring()
            string descriptionSubString = description.Substring(0, 4);
            string descSubStr = description.Substring(5);
            Console.WriteLine(descriptionSubString);
            Console.WriteLine(descSubStr);


            //Split()
            string assistantName = "Ivo Kostovski";
            string[] fullNameSplited = assistantName.Split("");
            foreach (string name in fullNameSplited)
            {
                Console.WriteLine(name);
            }

            string[] worldSplited = worldHealthTitle.Split("-");
            foreach (string item in worldSplited)
            {
                Console.WriteLine(item.Trim());
            }

            //ToCharArray()
            char[] fullNameChars = fullName.ToCharArray();
            foreach (char character in fullNameChars)
            {
                Console.WriteLine(character);
            }

            //Contains
            bool hasCharacterInFulName = fullName.Contains('i');
            if (hasCharacterInFulName)
            {
                Console.WriteLine(fullName);
            }
            #endregion



            #region DateTime and DateTime manipulation

            DateTime date = new DateTime();
            Console.WriteLine(date);

            DateTime today = DateTime.Now;
            Console.WriteLine(today);

            //Creating a custom DateTime - my birthday
            DateTime birthday = new DateTime(1993, 08, 27, 13, 5, 12);
            Console.WriteLine(birthday);

            //DateTime combinations and from String conversion
            string date1 = "05/10/2020";
            string date2 = "05.10.2020";
            string date3 = "05/10/2020 13:05:12";
            string date4 = "05-10-2020";
            string date5 = "may.10.2020";

            //Console.WriteLine("DateTime converted from string:");
            DateTime convertedDate1 = DateTime.Parse(date1);
            DateTime convertedDate2 = DateTime.Parse(date2);
            DateTime convertedDate3 = DateTime.Parse(date3);
            DateTime convertedDate4 = DateTime.Parse(date4);
            DateTime convertedDate5 = DateTime.Parse(date5);

            Console.WriteLine(convertedDate1);
            Console.WriteLine(convertedDate2);
            Console.WriteLine(convertedDate3);
            Console.WriteLine(convertedDate4);
            Console.WriteLine(convertedDate5);


            //Formating dates
            int day = today.Day;
            int month = today.Month;
            int year = today.Year;

            Console.WriteLine($"Day: {day} Month: {month} Year: {year}");

            DateTime currentDate = today.Date;
            Console.WriteLine(currentDate);

            Console.WriteLine("Tomorrow is " + currentDate.AddDays(1));
            Console.WriteLine("Yesterday was " + currentDate.AddDays(-1));

            string dateFormat = today.ToString("MM/dd/yyyy");
            Console.WriteLine(dateFormat);

            string dateFormat2 = today.ToString("dddd, dd MMMM yyyy");
            Console.WriteLine(dateFormat2);


            //First check the format
            var check = DateTime.Now;
            Console.WriteLine("Format is: " + check);



            #endregion

            Console.ReadLine();
        }

    }
}
