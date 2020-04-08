## Domain/Service Classes Extra Exercise

* Create a Console App: **Songs**
* Create 2 Class Library Projects: **DomainModels** and **Services**
* Create 2 Classes: **SongModel** and **SongService**. And put them in the correlated Class Library Projects
* Create an **array** of SongModel in the Console App: Songs
* In the Console App: Songs, use some of the service methods of the SongService. Use the array you created 

## Details about the classes

### SongModel(Domain Model Class):
* **(constructor)** Empty constructor with default values
* **(constructor)** Full constructor with all values taken by parameters (name, band, length, genre, author, language)
* Name: **string**
* Band: **string**
* Length: **int** (should be in seconds)
* Genre: **enum** (you should create enum named "Genre" and set some values in it, for example: Rock, Jazz, Instrumental...)
* Author: **string**
* Language: **string**

### SongService(Service Class):
* FindByName(**SongModel[]** songs, **string** name) => should return **SongModel**
* FindByAuthor(**SongModel[]** songs, **string** author) => should return **SongModel[]**
* FindByGenre(**SongModel[]** songs, **Genre** genre) => should return **SongModel[]**
* FindSongsLongerThan(**SongModel[]** songs, int seconds) => should return **SongModel[]**
* FindSongsShorterThan(**SongModel[]** songs, int seconds) => should return **SongModel[]**
* AddSong(**SongModel[]** songs, **SongModel** book) => **void**
