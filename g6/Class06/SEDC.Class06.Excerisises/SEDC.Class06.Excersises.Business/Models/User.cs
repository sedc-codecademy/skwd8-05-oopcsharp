using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class06.Excersises.Business.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime CreatedOn { get; set; }

        public User(string email, string password, string firstName, string lastName, DateTime dateOfBirth)
        {
            Id = GenerateId();
            Email = email;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            CreatedOn = DateTime.Now;
        }

        public string GetInfo()
        {
            return string.Format("Name: {0} Date of birth: {1}", GetFullName(), DateOfBirth.Date);
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        private int GenerateId()
        {
            Random rand = new Random();
            return rand.Next(0, 10_000_000);
        }
    }
}
