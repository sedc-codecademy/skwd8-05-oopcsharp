namespace Models
{
    public class Movie
    {
        public string Title { get; set; }
        public float Rating { get; set; }
        public int Year { get; set; }
        public int Duration { get; set; }

        public string GetInfo()
        {
            return $"{Title} ({Year}) Rating: {Rating} Duration: {Duration} minutes.";
        }
    }
}
