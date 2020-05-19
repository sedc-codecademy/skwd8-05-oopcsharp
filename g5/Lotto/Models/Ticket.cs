using System;
using System.Collections.Generic;

namespace Models
{
    public class Ticket
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public List<int> Numbers { get; set; }
        public float Payment { get; set; }
        public float Price { get; set; }
        public Guid UserId { get; set; }
        public TicketStatus Status { get; set; }
        public int RoundNumber { get; set; }

        public Ticket()
        {
        }

        public Ticket(List<int> numbers, float payment, Guid userId, int roundNumber)
        {
            Id = Guid.NewGuid();
            Date = DateTime.Now;
            Numbers = numbers;
            Payment = payment;
            Price = 0;
            UserId = userId;
            Status = TicketStatus.InProgress;
            RoundNumber = roundNumber;
        }
    }
}
