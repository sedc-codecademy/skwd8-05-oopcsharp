using SEDC.VideoRental.Data.Models;
using System.Collections.Generic;

namespace SEDC.VideoRental.Data.Database
{
    public class InMemoryDatabase
    {
        protected List<User> Users { get; set; }
        protected List<Movie> Movies { get; set; }

        public InMemoryDatabase()
        {
            InitDatabase();
        }

        private void InitDatabase()
        {
            Users = new List<User>
            {
                new User() { CardNumber = 123, FullName = "Trajan Stevkovski" }
            };

            Movies = new List<Movie>
            {

            };
        }
    }
}
