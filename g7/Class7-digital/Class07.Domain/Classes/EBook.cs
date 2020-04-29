using System;
using System.Collections.Generic;
using System.Text;

namespace Class07.Domain.Classes
{
	public class EBook : Book // Title, Author, Genre etc. inherits from Book
	{
		public int Size { get; set; }
		private string Link { get; set; }
		public EBook(int isbn, string title, string author, BookGenre genre, int pages, int size, string link)
			: base(isbn, title, author, genre, pages)
		{
			Size = size;
			Link = link;
		}
		public override string FullInfo()
		{
			return base.FullInfo() + $" {Size}MB";
		}
		public string GetDownloadLink()
		{
			// return a private string -> Can use it, can see it, can't change it
			// no return, just Console.WriteLine -> Can see it, can't use it, can't change it
			return $"https://bookstore.com/{Link}";
		}
	}
}
