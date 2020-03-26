using System;

namespace Exe2
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj1 = 5;
            int broj2 = 3;
            int zbir = Sum(broj1, broj2);

            string note = "Zbirot na broevite " + broj1 + " i " + broj2 + " e: " + zbir;
            Console.WriteLine(note);

            string note2 = string.Format("Zbirot na broevite {0} i {1} e: {2}", broj1, broj2, zbir);
            Console.WriteLine(note2);

            string note3 = $"Zbirot na broevite {broj1} i {broj2} e: {zbir}";
            Console.WriteLine(note3);

            string note4 = "Example \n text";
            string note5 = "Example \\ text";
            string note6 = "Example \"text\"";
            Console.WriteLine(note6);

            string note7 = @"C:\Risto\Test\Folder1";
            string note8 = @$"C:\Risto\Test\Folder1\{broj1}";
            string note9 = @"Example ""text""";
            Console.WriteLine(note9);

            int price = 150;
            string formattedPrice = price.ToString("C");
            Console.WriteLine(formattedPrice);

            double percent = 0.95;
            string formattedPrecent = percent.ToString("P");
            Console.WriteLine(formattedPrecent);
        }

        public static int Sum(int a, int b)
        {
            int result = a + b;
            return result;
        }
    }
}
