using SEDC.VideoRental.Data.Models;
using System.Linq;

namespace SEDC.VideoRental.Data.Database
{
    public class UserRepository : InMemoryDatabase
    {
        public User GetUserByIdCard(int idCard)
        {
            return Users.FirstOrDefault(_user => _user.CardNumber == idCard);
        }

        public bool CreateUser(User user)
        {
            var beforeCount = Users.Count;
            Users.Add(user);

            return beforeCount != Users.Count;
        }
    }
}
