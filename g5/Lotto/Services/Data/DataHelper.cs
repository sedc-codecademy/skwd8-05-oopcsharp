using System.Collections.Generic;
using Models;

namespace Services.Data
{
    public static class DataHelper
    {
        public static List<User> Users { get; set; } = new List<User>();
        public static Lotto LottoOrganization { get; set; }

        public static Dictionary<TicketStatus, int> PriceTable = new Dictionary<TicketStatus, int>()
        {
            {TicketStatus.Win4, 10 },
            {TicketStatus.Win5, 100 },
            {TicketStatus.Win6, 1000 },
            {TicketStatus.Win7, 10000 }
        };
    }
}
