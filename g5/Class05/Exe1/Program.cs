using System;
using Newtonsoft.Json;
using Models;

namespace Exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            User firstUser = new User()
            {
                FirstName = "Risto",
                LastName = "Panchevski",
                Age = 30
            };

            User secondUser = new User("Toshe", "Toshevski", 12);

            Console.WriteLine(firstUser.UserInfo());
            Console.WriteLine(secondUser.UserInfo());

            string json = JsonConvert.SerializeObject(firstUser);
        }
    }
}
