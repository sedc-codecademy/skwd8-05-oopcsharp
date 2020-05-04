using Class07.Domain.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class07.Domain.Services
{
	public class BookService
	{
		HelperService _helperService = new HelperService();
		// We needed a way to store our books in this service
		// In real world these will be filled with DB books instead of hardcoded
		public HardCoverBook[] Books;
		public EBook[] EBooks;
		public BookService()
		{
			Books = new HardCoverBook[]
			{
				new HardCoverBook(12124214, "Best Book Ever", "Damjan Stojanovski", BookGenre.Adventure, 200, 10, new DateTime(1990, 10, 23)),
				new HardCoverBook(213214, "Best Comic Ever", "Jill Wayne" , BookGenre.Fantasy, 12, 23, new DateTime(1940, 3, 12)),
				new HardCoverBook(1414213, "Not so good book", "Greg Gregsky" , BookGenre.SciFi, 300, 4, new DateTime(2012, 12, 1))
			};
			EBooks = new EBook[]
			{
				new EBook(435435, "Awesome stories", "Bob Bobsky" , BookGenre.Mistery, 145, 12, "mistery/awesomestories"),
				new EBook(54364363, "Learning C# the hard way", "Dragan Draganov" , BookGenre.SciFi, 256, 22, "programming/learningcsharpthehardway"),
				new EBook(43535454, "Bulding a custom website with no effort", "Meti Meti" , BookGenre.Fantasy, 30, 4, "mistery/buildingawebsitein10min")
			};
		}
		public void PrintAllBooks(string BookType)
		{
			if(BookType.ToLower() == "hardcoverbook" ||
				BookType.ToLower() == "book")
			{
				foreach (var book in Books)
				{
					Console.WriteLine(book.FullInfo());
				}
			} 
			else if(BookType.ToLower() == "ebook")
			{
				foreach (var ebook in EBooks)
				{
					Console.WriteLine(ebook.FullInfo());
				}
			} else
			{
				Console.WriteLine("The input was not ebook or book so here are all the books!");
				foreach (var book in Books)
				{
					Console.WriteLine(book.FullInfo());
				}
				foreach (var ebook in EBooks)
				{
					Console.WriteLine(ebook.FullInfo());
				}
			}
		}
		// User ui
		// Pick a book:
		// 1) funny book bla bla
		// 2) other book bla bla
		// ...
		// We decide to request for index
		// The index will be connected to the menu numbers
		// When we get the index we will match it with an idex of the array of books
		public HardCoverBook RentBook(int index)
		{
			if (Books[index].IsInStock()) // Check if there is at least 1 book in stock
			{
				Books[index].InStock--; // Remove 1 book from stock
				return Books[index]; // Give one book to user
			}
			return null;
		}
		// We need to show the books dynamically as options to the user ( as shown above )
		public HardCoverBook ChooseHardCover()
		{
			while (true)
			{
				Console.WriteLine("Choose a book:");
				for (int i = 1; i <= Books.Length; i++)
				{
					Console.WriteLine($"{i}) {Books[i - 1].FullInfo()}");
				}
				// If you want to check the implemetation of a function just select it and hit F12
				int choice = _helperService.ValidatePositiveNumber(Console.ReadLine(), Books.Length);
				if (choice == -1) continue; // -1 is from the function ValidatePositiveNumber
				return Books[choice - 1];
			}
		}

		// TODO -> Return a book
	}
}
