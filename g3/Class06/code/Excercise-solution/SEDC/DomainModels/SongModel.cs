using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels
{
    public class SongModel
    {
        public string Name { get; set; }
        public string Band { get; set; }
        public int Length { get; set; }
        public Genre Genre { get; set; }
        public string Author { get; set; }
        public string Language { get; set; }
    }
}
