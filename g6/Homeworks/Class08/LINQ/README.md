# Homework Class 8 - LINQ 📒
## Task 1
* Create a class Song with the following properties: Title, Length and, Genre
* Genre is enum with - Rock, Hip_Hop, Techno and Classical
* Create a class Person with the following properties
  * Id
  * FirstName
  * LastName
  * Age
  * FavoriteMusicType (Genre enum)
  * FavoriteSongs
* FavoriteSongs is a list of Songs
* Create a method called GetFavSongs() that will print out all the titles of their favorite songs or write a message that this person hates music if there are no favorite songs in their list

## Task 2
* Select the person Jerry and add all the songs which start with the letter B
* Select the person Maria and add all the songs with length longer than 6 mins
* Select the person Jane and add all the songs that are of genre Rock
* Select the person Stefan and add all songs shorter than 3 mins and of genre Hip-Hop
* Select all persons from the persons array that have 4 or more songs

> Note: USE LINQ

## Data 🎁

```c#
List<Person> FansArray = new List<Person>();

//fans
Person Jerry = new Person("Jerry", "Tompson", 78, Genre.Rock);
Person Stefan = new Person("Stefan", "Stefanoski", 28, Genre.Techno);
Person Maria = new Person("Maria", "Campbel", 43, Genre.Classical);
Person Jane = new Person("Jane", "Doe", 28, Genre.Techno);

//songs
Song song1 = new Song("Bohemian Rhapsody", 367, Genre.Rock);
Song song2 = new Song("Stairway To Heaven", 480, Genre.Rock);
Song song3 = new Song("Riders On The Storm", 430, Genre.Rock);
Song song4 = new Song("Not Fade Away", 108, Genre.Rock);
Song song5 = new Song("Breaking Glass", 111, Genre.Rock);
Song song6 = new Song("Welcome To The Jungle", 275, Genre.Rock);
Song song7 = new Song("Walk Of Life", 266, Genre.Rock);
Song song8 = new Song("Smoke on the Water", 340, Genre.Rock);
Song song9 = new Song("93 'til Infinity", 209, Genre.Techno);
Song song10 = new Song("Fight the Power", 321, Genre.Techno);
Song song11 = new Song("The Message", 363, Genre.Techno);
Song song12 = new Song("Butterfly Effect", 213, Genre.Techno);
Song song13 = new Song("No Fear", 182, Genre.Techno);
Song song14 = new Song("Hereditary", 340, Genre.Techno);
Song song15 = new Song("Bounce Back", 226, Genre.Techno);
Song song16 = new Song("The Four Seasons", 2520, Genre.Classical);
Song song17 = new Song("Canon in D major", 376, Genre.Classical);
Song song18 = new Song("Swan Lake", 461, Genre.Classical);
Song song19 = new Song("Symphony No. 5", 425, Genre.Classical);
Song song20 = new Song("Ride of the Valkyries", 608, Genre.Classical);
Song song21 = new Song("The Magic Flute", 458, Genre.Classical);
Song song22 = new Song("Carmen Suite No.1", 721, Genre.Classical);
Song song23 = new Song("Planet E", 420, Genre.Techno);
Song song24 = new Song("Phasor", 368, Genre.Techno);
Song song25 = new Song("Counting Comets", 242, Genre.Techno);
Song song26 = new Song("Cold Summer", 358, Genre.Techno);
Song song27 = new Song("Destroyer", 359, Genre.Techno);
Song song28 = new Song("Phalanx", 307, Genre.Techno);
Song song29 = new Song("Vision", 693, Genre.Techno);
Song song30 = new Song("Chain Reaction", 181, Genre.Techno);

List<Song> Songs = new List<Song>() { song1, song2, song3, song4, song5, song6, song7,
                                    song8, song9, song10, song11, song12, song13, song14,
                                    song15, song16, song17, song18, song19, song20,
                                    song21, song22, song23, song24, song25, song26, song27, song28, song29, song30 };

FansArray.Add(Jerry);
FansArray.Add(Stefan);
FansArray.Add(Maria);
FansArray.Add(Jane);
```
