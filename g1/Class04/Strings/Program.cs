using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We are starting with STRINGS:  :)");

            //String building
            string academy = "Seavus Educational and Development Center";
            string academyAcronym = "SEDC";

            //Concatenating strings 
            //Seavus Educational and Development Center - SEDC
            //string academyTitle = academy + " - " + academyAcronym;

            //Formatting String - PLACEHOLDERS
            Console.WriteLine("{0} - {1}", academy, academyAcronym);

            //String Format
            string academyTitle = string.Format("{0} - {1}", academy, academyAcronym);
            Console.WriteLine(academyTitle);
            
            float price = 150.28f;
            string currency = string.Format("{0:C}", price);
            Console.WriteLine(currency);

            float part = 0.5f;
            string percent = string.Format("{0:P}", part);
            Console.WriteLine(percent);

            var mobileNumber = 38970111222;
            string mobileNumberFancy = string.Format("{0:(###) ## ###-###}", mobileNumber);
            Console.WriteLine(mobileNumberFancy);

            //STRINGS INTERPOLATION
            string group = "G1";
            string behaviour = "Rocks!";

            string what = $"{group} are amazing! The group {behaviour}";
            Console.WriteLine(what);

            //ESCAPING CHARACTERS
            string path = @"C:\Users\Miodrag.Cekikj\Desktop\SEDC\SEDC2019-2020\Online\G1";
            Console.WriteLine(path);
            
            // /n - new line
            // /t - tab
            string withQuotations = @"Online \n training is GREAT";
            Console.WriteLine(withQuotations);

            //Console.WriteLine(academyTitle);

            Console.ReadLine();
        }
    }
}
