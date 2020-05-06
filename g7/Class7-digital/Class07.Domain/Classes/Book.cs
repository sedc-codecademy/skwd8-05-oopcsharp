using System;
using System.Collections.Generic;
using System.Text;

namespace Class07.Domain.Classes
{
	// Two types of books:
	// Hard Cover Copy of book - > Rent the copys
	// EBook - > Download a copy
	public class Book
	{
		public int ISBN { get; set; }
		public string Title { get; set; }
		public string Author { get; set; }
		public BookGenre Genre { get; set; }
		public int Pages { get; set; }
		public Book()
		{
			Genre = BookGenre.Unknown;
		}
		public Book(int isbn, string title, string author, BookGenre genre, int pages)
		{
			ISBN = isbn;
			Title = title;
			Author = author;
			Genre = genre;
			Pages = pages;
		}
		public virtual string FullInfo()
		{
			return $"[{Genre}] {Title} - {Author} Pages: {Pages}";
		}
	}
}
