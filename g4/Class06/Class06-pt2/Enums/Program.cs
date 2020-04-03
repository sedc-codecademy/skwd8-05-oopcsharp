
using Academy;
using AcademyApp.Helpers;
using System;

namespace AcademyApp
{
    class Program
    {
        // example for asignment for variable with type enum
        public DayOfWeek[] scheduledClasses { get; set; }

        public enum DaysOfWeek
        {
            // We can change the enum value
            // By default is 0 and incrementing for 1
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            #region Enums
            DateTime today = DateTime.Now;
            // example of casting into integer
            int dayOfWeek = (int)today.DayOfWeek;
            //Console.WriteLine(dayOfWeek);

            // this is an edge case, we ussualy compare enum to enum
            if (dayOfWeek == (int)DaysOfWeek.Friday)
            {
                //Console.WriteLine("PARTYYYY !!");
            }
            #endregion

            // Creating objects from class Participant
            Participant trainer1 = new Participant("Dejan", "Jovanov", 28, AcademyRole.CoTrainer);
            // trainer1.Role = AcademyRole.CoTrainer;
            // trainer1.PrintParticipant();

            Participant trainer2 = new Participant("Kristina", "Spasevska", 33, AcademyRole.CoTrainer);

            Participant student1 = new Participant("Radmila", "Sokolovska", 34, AcademyRole.Student);
            Participant student2 = new Participant("Blagoja", "Grozdanovski", 30, AcademyRole.Student);

            Participant[] academyParticipants = new Participant[]
            {
                trainer1,
                trainer2,
                student1,
                student2
            };

            // Using helper method which is defined with STATIC access modifier, and can be 
            // invoked without instanciating object from the class
            ParticipantHelper.FindParticipantByRole(AcademyRole.CoTrainer, academyParticipants);


            Console.ReadLine();
        }

    }
}
