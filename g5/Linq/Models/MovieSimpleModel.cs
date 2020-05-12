namespace Models
{
    public class MovieSimpleModel
    {
        public string Title { get; set; }
        public float Rating { get; set; }

        public MovieSimpleModel(string title, float rating)
        {
            Title = title;
            Rating = rating;
        }
    }
}
