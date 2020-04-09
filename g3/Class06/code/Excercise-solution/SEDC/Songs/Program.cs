using DomainModels;
using Services;
using System;

namespace Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            SongService songService = new SongService();

            SongModel song1 = new SongModel
            {
                Name = "marakana",
                Length = 300
            };
            SongModel song2 = new SongModel
            {
                Name = "marakana",
                Length = 250
            };
            SongModel song3 = new SongModel
            {
                Name = "marakana",
                Length = 150
            };
            SongModel song4 = new SongModel
            {
                Name = "marakana",
                Length = 100
            };

            SongModel[] songs = new SongModel[] { song1, song2, song3, song4 };

            SongModel makarena = songService.FindByName(songs, "makarena");
            SongModel[] rockSongs = songService.FindSongsLongerThan(songs, 200);

            SongModel rockYouLikeAhur = songService.FindByName(rockSongs, "Rock You LikeAhur");

            Console.ReadLine();
        }
    }
}
