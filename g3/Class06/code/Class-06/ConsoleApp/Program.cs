using System;

namespace ConsoleApp
{
    class Program
    {
        // Domain Model Classes
        // Service Classes
        static void Main(string[] args)
        {
            LoginService loginService = new LoginService();
            loginService.LogIn("sedc.academy2", "4321");
            //loginService.LogIn(user);

            Console.Read();
        }
    }
}
