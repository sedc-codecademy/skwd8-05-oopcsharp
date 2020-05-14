# Video Rental App Requriements

Video rental app where we can rent movie videos online.

## Part 1
1. The solution will have 2 class libraries and 1 application console project:
	- Application (console app)
	- Business domain (class library)
	- Data domain (class library)

2. Models needed for our app:

	User

	- Id
	- FullName
	- Age
	- CardNumber
	- CreatedOn
	- RentedMovies
	- RentedMoviesHistory
	- IsSubscriptionExpired
	- SubscriptionType - optional

	Movie

	- Id
	- Title
	- Genre
	- Language
	- IsAvailable
	- ReleaseDate
	- Length
	- AgeRestriction
	- Quantity
	- Crew and Cast - optional

	Cart - optional

3. In memory database which will live through the application
	- Movies
	- Users
4. Repositories - where we can get and manipulate with the data using LINQ

	Users 
	- Get user by card number
	- Create user

	Movies
	- Get all movies - paging optional
	- Get by genre
	- Sort by genre
	- Sort by release date
	- Get by year
	- Sort/Get by availability
	- Search by title

## Part 2

Add funtionalities for the user to:
1. View all movies
	*  Order movies
	*  Get movies by genre
	*  Get movies by release year
	*  Search movies by title
	*  Rent a video
2. View history
	*  History of rented videos
	*  Suggestions - optional
3. View rented videos
	*  Videos in users hands
    *  Return videos
