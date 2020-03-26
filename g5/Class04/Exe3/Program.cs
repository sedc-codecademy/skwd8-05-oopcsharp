using System;

namespace Exe3
{
    class Program
    {
        static void Main(string[] args)
        {
            string note = "    Risto Panchevski    ";
            Console.WriteLine(note.ToLower());
            Console.WriteLine(note.ToUpper());
            Console.WriteLine(note.Trim());

            string note1 = "C# Basic";
            int length = note1.Length;
            Console.WriteLine(length);

            bool result = note1.StartsWith("C#");
            bool result1 = note1.StartsWith("c#", StringComparison.OrdinalIgnoreCase);
            bool result3 = note1.Contains("z");
            Console.WriteLine(result);

            int indexA = note1.IndexOf("a");
            int indexSi = note1.IndexOf("si");

            string substring3End = note1.Substring(3);
            string substring32 = note1.Substring(3, 2);

            string note2 = "G5 is having online course for C# Basic";
            string[] splitVar = note2.Split(" ");

            string note3 = "G5 is having| online course |for C# Basic";
            string[] splitPipe = note3.Split("|");

            char[] charArray = note3.ToCharArray();
        }
    }
}
