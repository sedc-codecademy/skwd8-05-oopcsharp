using SEDC.VideoRental.Data.BaseModels;
using System;
using System.Collections.Generic;

namespace SEDC.VideoRental.Data.Models
{
    public class User : BaseEntity
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int CardNumber { get; set; }
        public bool IsSubscriptionExpired { get; set; }
        //public DateTime SubscriptionRenewed { get; set; }???????

        public bool IsAdmin { get; set; }

        public List<RentalInfo> RentedMovies { get; set; }
        public List<RentalInfo> RentedMoviesHistory { get; set; }

        public User()
        {
            IsSubscriptionExpired = false;
            RentedMovies = new List<RentalInfo>();
            RentedMoviesHistory = new List<RentalInfo>();
        }
    }
}
