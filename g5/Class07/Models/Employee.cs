namespace Models
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        protected double Salary { get; set; }

        public Employee()
        {
            
        }

        public Employee(string firstName, string lastName, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }

        public string GetInfo()
        {
            return $"{FirstName} {LastName} ({Salary})";
        }

        public double GetSalary()
        {
            return Salary;
        }
    }
}
