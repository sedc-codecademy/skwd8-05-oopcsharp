using System;

namespace SEDC.Class04.Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Trajan";
            string emtpyString = "Stevkovski";

            string concatString = str + " " + emtpyString;

            string text = "Program: Hello {0}, Program: How are you today? {1}: Im good. ";
            string textFormated = string.Format(text, str, str);

            int phoneNumber = 078270396; // 078-270-396
            string formatedPhoneNumber = FormatPhoneNumber(phoneNumber);

            string str2 = $"Program: Hello {str}, Program: How are you today? {str}: Im good. ";
             
            string str3 = "C:\\SEDC";
            string str4 = @"C:\SEDC";
            string str5 = "Hello \"World\" !!";
            string str6 = @"Hello ""World"" !!";

            string path = "SEDC";
            string str7 = @$"C:\{path}";

            int stringLength = str7.Length;
            string toLower = str2.ToLower();

            bool startsWith = str2.StartsWith("Program");
            bool startsWithCaseInsensitive = str2.ToUpper().StartsWith("Program".ToUpper());

            //string fullName = string.Format("{0} {1} {2} {3} {4}", str, emtpyString, str, str, emtpyString);
            
            
            string str111 = $"Program: Hello {str}, Program: How are you today? {str}: Im good. ";
            string today = "good";
            int indexOf = str2.IndexOf(today);
            string substr = str2.Substring(44, 5);
            int strLength = "asdasddasdasd".Length;

            string subStr = str2.Substring(indexOf, today.Length);

            string trimedString = str2.Trim();
            string[] splitedString = trimedString.Split(' ');
            //foreach (string item in splitedString)
            //{
            //    Console.WriteLine(item);
            //}

            string str02 = $"Program: Hello {str}, Program: How are you today? {str}: Im good. ";

            char[] charArray = str02.ToCharArray();
            //foreach (char item in charArray)
            //{
            //    if(item == 'a')
            //    {
            //        Console.Write(item.ToString().ToUpper());
            //        continue;
            //    }
            //    Console.Write(item);
            //}

            string joinedString = string.Join(':', splitedString);

            string str03 = "Program: Hello {{name}}, Program: How are you today? {{name}}: Im good. ";
            string replacedString = str03.Replace("{{name}}", str).Replace("Program", "Toshe");

            string notTrimedString = "              Trajan                  ";
            string trimedString1 = "+" + notTrimedString.Trim() + "+";
            string testString = "+" + notTrimedString + "+";


            Console.WriteLine(testString);

            Console.ReadLine();
        }

        public static string FormatPhoneNumber(int phoneNumber)
        {
            return string.Format("{0:0##-###-###}", phoneNumber);
        }
    }
}
