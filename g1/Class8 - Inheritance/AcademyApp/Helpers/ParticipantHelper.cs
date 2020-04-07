using System;
using AcademyApp.Entities;
using AcademyApp.Enums;

namespace AcademyApp.Helpers
{
    public class ParticipantHelper
    {
        public static void FindParticipantByRole(Participant[] participants, AcademyRole role)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            foreach (var participant in participants)
            {
                if (participant.Role == role)
                    participant.PrintFullName();
            }
        }
    }
}