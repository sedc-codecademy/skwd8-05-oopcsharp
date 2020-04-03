namespace Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public string UserInfo()
        {
            string info = $"{FirstName} {LastName} - {Age}";
            return info;
        }

        public User() { }

        public User(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }
}
