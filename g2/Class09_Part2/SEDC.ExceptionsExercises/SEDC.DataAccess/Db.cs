using SEDC.DomainModels;
using System;
using System.Collections.Generic;

namespace SEDC.DataAccess
{
    public class Db
    {
        public static List<Post> Posts()
        {
            return new List<Post>
            {
                new Post(1, "Hello G1", "Hi guys, the demo code is alread uploaded!", "Miodrag Cekikj"),
                new Post(2, "[G2]", "Hi all! The code and the presentation are uploaded! For extra info ping Ivo please!", "Martin Panovski"),
                new Post(3, "Hello guys!", "Hi guys, the homework is already on github.", "Dragan Gelevski"),
                new Post(4, "Extra materials alert!", "Hi, the extra exercises are uploaded on github", "Dejan Jovanov")
            };
        }
    }
}
