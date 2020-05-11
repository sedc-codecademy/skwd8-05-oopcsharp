using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class10.Models
{
    public class Cinema
    {
        public string Name { get; set; }
        public int Halls { get; set; }

        public List<Movie> Movies { get; set; }
    }
}
