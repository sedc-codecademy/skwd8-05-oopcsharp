using Academy;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyApp.Helpers
{
    public class ParticipantHelper
    {
        public static void FindParticipantByRole(AcademyRole role, Participant[] participants)
        {
            foreach (var participant in participants)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                if (participant.Role == role)
                {
                    participant.PrintParticipant();
                }
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }

    }
}
