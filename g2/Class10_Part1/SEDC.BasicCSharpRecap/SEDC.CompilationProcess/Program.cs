using SEDC.Helpers;
using System;
using System.Security.Cryptography;

namespace SEDC.CompilationProcess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string fullName = Helper.GetFullName("Martin", "Panovski");
            Console.WriteLine(fullName);


            for(int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);

                Console.WriteLine("Something else....");
            }
            

            int number = 100;

            if(number > 89)
            {
                number = 1000;
            }

            Test(number);

            if(number  >= 0)
            {
                number = 50;
            }
            Console.WriteLine(number);

            Console.ReadLine();
        }

        public static void Test(int num)
        {
            num++;
            Console.WriteLine(num);

            num = 120;
            Console.WriteLine(num);

            num = 0;
            Console.WriteLine(num);
        }
    }
}
