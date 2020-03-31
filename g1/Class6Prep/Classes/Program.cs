using System;

namespace Classes
{
    public class Participant
    {
        public Participant()
        {

        }

        private int Age;

        public string FirstName;
        public string LastName;

        public DateTime DateOfBirth;

        public void Greetings()
        {
            Console.WriteLine($"Hello, I`m {FirstName} {LastName}");

            HowOld(DateTime.Today);
            Console.WriteLine($"Also, I`m {Age} years old. :)");
        }

        private void HowOld(DateTime today)
        {
            if (today.Month < DateOfBirth.Month)
                Age = today.Year - DateOfBirth.Year - 1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Participant participant1 = new Participant();

            participant1.FirstName = "Miodrag";
            participant1.LastName = "Cekikj";
            participant1.DateOfBirth = new DateTime(1989, 5, 15);
            participant1.Greetings();

            var participant2 = new Participant();
            participant2.FirstName = "Goce";
            participant2.LastName = "Kabov";
            participant2.DateOfBirth = new DateTime(1992, 5, 15);
            participant2.Greetings();

            Console.ReadLine();
        }
    }
}