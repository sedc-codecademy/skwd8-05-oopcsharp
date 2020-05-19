using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Models;

namespace WebApi.Fake_Database
{
     internal static class DB
     {
        internal static List<User> Users = MockData.GetMockedUsers();
     }
}
