namespace Models
{
    public class Subject
    {
        public string Name { get; set; }
        public int NumberOfClasses { get; set; }

        public Subject(string name, int numberOfClasses)
        {
            Name = name;
            NumberOfClasses = numberOfClasses;
        }
    }
}
