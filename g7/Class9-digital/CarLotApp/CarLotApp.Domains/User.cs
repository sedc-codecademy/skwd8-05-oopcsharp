using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotApp.Domains
{
    public class User
    {
        public User(int id,string firstName,string lastName,int age, bool isCapableOfPurchase)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            IsCapbleOfPurchising = isCapableOfPurchase;
            Cars = new List<Car>();
        }
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool IsCapbleOfPurchising { get; set; }
        public List<Car> Cars { get; set; }
    }
}
