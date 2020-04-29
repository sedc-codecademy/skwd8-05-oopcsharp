using System;
using System.Collections.Generic;
using System.Text;

namespace Class07.Domain.Classes
{
	// new Book() == base()
	// new HardCoverBook() == HardCoverBook() : base()
	// [Initialization of the class] We name the lass, set access modifier and add inheritance if needed
	// We need the inheritance because we want this class to inherit from Book
	public class HardCoverBook : Book // Title, Author, Genre etc. inherits from Book
	{
		// There can't be 2 base
		// [Properties] We use only the specific properties for HardCoverBook. The others come from Book
		public int InStock { get; set; } // How many books are left
		public DateTime DateIssued { get; set; } // When the book is issued ( DateTime is the type since we are working with dates )
		
		// [Constructor] We created a constructor because we want to created objects from this class easier
		public HardCoverBook(int isbn, string title, string author, BookGenre genre, 
			int pages, int inStock, DateTime dateIssued) // we used base so we don't have to connect the first 5 prperties since we have them in the Author constructor
			: base(isbn, title, author, genre, pages) // EQUIVALENT -> new Author(isbn, title, author, genre, pages)
		{
			// We only connect the unique properties, the others are set in base()
			InStock = inStock;
			DateIssued = dateIssued;
		}
		// [IsInStock method] We decide to add IsInStock method so that 
		// every time we need to check if a book is in stock we just call the method, instead of making the logic at the spot
		public bool IsInStock()
		{
			if (InStock <= 0) return false;
			return true;
		}
	}
}
