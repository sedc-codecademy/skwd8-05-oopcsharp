using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Exe2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] broevi = new int[7];
            broevi[0] = 10;
            broevi[1] = 11;
            broevi[2] = 12;
            broevi[3] = 13;
            broevi[4] = 14;
            broevi[5] = 15;
            broevi[6] = 16;
            //Pristap do index koj sto e nadvor od opsegot definiran vo deklaracijat na borevi.
            //broevi[7] = 17;
            //broevi[8] = 18;

            Array.Reverse(broevi);

            string[] iminja = new string[3] {"Aleksandar", "Martin", "Vlatko"};

            Console.WriteLine(iminja[1]);
            int index = Array.IndexOf(iminja, "Martin");
            int index2 = Array.IndexOf(iminja, "Vlatko");
            int index1 = Array.IndexOf(iminja, "Test");

            iminja[1] = "Risto";

            Console.WriteLine(iminja[1]);

            Console.WriteLine(iminja.Length);

            int[] numbers = new int[5]{ 1, 2, 3, 4, 5 };
            Array.Resize(ref numbers, 3);

            foreach (string ime in iminja)
            {
                Console.WriteLine("Student: " + ime);
            }
        }
    }
}
