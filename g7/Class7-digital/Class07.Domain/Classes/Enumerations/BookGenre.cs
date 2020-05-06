using System;
using System.Collections.Generic;
using System.Text;

// We changed the namespace here as well
namespace Class07.Domain.Classes
{
	public enum BookGenre
	{
		Unknown, // Any of the other values can't be a default one, so that is why we have this
		Fantasy,
		Adventure,
		Romance,
		Mistery,
		Horror,
		Thriller,
		SciFi, 
		Other // If for some reason we find a book that we sell, that is not of the above genres
	}
}
