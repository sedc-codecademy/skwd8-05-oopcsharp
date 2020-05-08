using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace LibraryApp.Models.Book
{
    public class EBook: Book
    {
        public string Link { get; set; }
        public int Size { get; set; }

        public EBook( string title, string author, Genres genre, int pages, string link, int size)
            :base(title, author, genre, pages)
        {
            Link = link;
            Size = size;
        }

        public override string BookInfo()
        {
            return $"{Id} {Title} - {Author} {Pages} pages ({Genre}) ({Size})MB";
        }
    }
}
