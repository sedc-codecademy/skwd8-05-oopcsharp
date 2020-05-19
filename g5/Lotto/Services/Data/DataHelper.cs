using System.Collections.Generic;
using Models;

namespace Services.Data
{
    public static class DataHelper
    {
        public static List<User> Users { get; set; } = new List<User>();
        public static Lotto LottoOrganization { get; set; }
    }
}
