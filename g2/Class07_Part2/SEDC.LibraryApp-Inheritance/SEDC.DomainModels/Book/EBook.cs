using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.DomainModels.Book
{
    public class EBook : Book
    {
        public string Link { get; set; }
        public int Size { get; set; }

        public EBook(string title, string author, Genre genre, int pages, string link, int size)
            :base(title, author, genre, pages)
        {
            this.Link = link;
            this.Size = size;
        }

        public override string BookInfo()
        {
            return $"{Title} - {Author} {Pages} pages ({Genre}) [{Size}MB]";
        }
    }
}
