using FakeFacebook.Logger;
using System;
using WebApi.Exceptions;
using WebApi.Service;

namespace FakeFacebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var allUsers = UserService.GetAllUsers();
            //foreach (var user in allUsers)
            //{
            //    Console.WriteLine(user.FirstName);
            //}
            try
            {
                // var userByID = UserService.GetUserById(4);
                var usersFriends = UserService.GetAllUsersFriends(null);
                foreach (var user in usersFriends)
                {
                    Console.WriteLine(user.FirstName);
                }
                // Console.WriteLine(userByID.FirstName);
            }
            catch (UserServiceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                var logger = new UserExceptionsLogger();
                logger.LogException(ex);
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("I proceed to work");
            Console.ReadLine();
        }
    }
}
