using SEDC.PostsApp.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PostsApp.DataAccess
{
    public static class Db
    {
        public static List<Post> Posts()
        {
            return new List<Post>
            {
                new Post(1, "Last class alert!", "Hi, today we are going to make something veryy cool", "Dejan Jovanov"),
                new Post(2, "[G2]", "Hi all! The code and the presentation are uploaded! ", "Martin Panovski"),
                new Post(3, "Hello G1", "Hi guys, the demo code is already uploaded!", "Miodrag Cekikj"),
                new Post(4, "Hello group 7!", "Hi guys, the homework is already on github.", "Dragan Gelevski"),
            };
        }
    }
}
