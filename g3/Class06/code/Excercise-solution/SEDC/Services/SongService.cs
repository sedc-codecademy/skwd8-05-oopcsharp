using DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class SongService
    {
        public SongModel FindByName(SongModel[] songs, string name)
        {
            foreach (SongModel song in songs)
            {
                if (song.Name == name)
                    return song;
            }

            return null;
        }

        //public void FindByName(SongModel[] songs, string name)
        //{
        //    foreach (SongModel song in songs)
        //    {
        //        if (song.Name == name)
        //            Console.WriteLine($"{song.Name} {song.Author} {song.Length}s");
        //    }
        //}

        public SongModel[] FindByAuthor(SongModel[] songs, string author)
        {
            return null;
        }

        public SongModel[] FindByGenre(SongModel[] songs, Genre genre)
        {
            return null;
        }

        public SongModel[] FindSongsLongerThan(SongModel[] songs, int seconds)
        {
            SongModel[] resultSongs = new SongModel[0];

            foreach (SongModel song in songs)
            {
                if (song.Length > seconds)
                {
                    Array.Resize(ref resultSongs, resultSongs.Length + 1);
                    resultSongs[resultSongs.Length - 1] = song;
                }
            }

            return resultSongs;
        }

        public SongModel[] FindSongsShorterThan(SongModel[] songs, int seconds)
        {
            return null;
        }

        public SongModel[] AddSong(SongModel[] songs, SongModel book)
        {
            return null;
        }
    }
}
