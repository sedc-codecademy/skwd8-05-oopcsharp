namespace LINQ.Homework.Models
{
    public class Song
    {
        public int Id { get; set; }
        public int AlbumId { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// duration in seconds
        /// </summary>
        public int Duration { get; set; }

        public Song() { }

        public Song(int id, int albumId, string name, int duration)
        {
            Id = id;
            AlbumId = albumId;
            Name = name;
            Duration = duration;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}