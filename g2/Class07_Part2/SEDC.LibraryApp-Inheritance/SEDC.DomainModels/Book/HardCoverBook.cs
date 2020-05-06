using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.DomainModels.Book
{
    public class HardCoverBook : Book
    {
        public int InStock { get; set; }
        public DateTime Printed { get; set; }
        public HardCoverBook(string title, string author, Genre genre, int pages, int inStock, DateTime printed)
            :base(title, author, genre, pages)
        {
            this.InStock = inStock;
            this.Printed = printed;
        }

        public override string BookInfo()
        {
            return $"{Title} - {Author} | {Pages} pages | Genre: {Genre} | Printed: {Printed}";
        }
    }
}
