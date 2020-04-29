using Class07.Domain.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class07.Domain.Services
{
	public class BookService
	{
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
	}
}
