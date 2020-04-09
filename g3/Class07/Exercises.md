# Task 1

* Create a Console App: **AcademyApp**
* Create 2 Class Library Projects: **Domain** and **Services**
* Create 3 Domain Classes: **Academy**, **Subject**, **Student**
* Create 1 Service Class: **AcademyService**  
**Note**: Put the new created classes in the correlated Class Library Projects

## Details about the classes

### Academy(Domain Model Class):
* **(constructor)** Takes (*name*, *description*, *subjects*) as parameters, **IsStarted** should be false
* Name: **string**
* Description: **string**
* Subjects: **Subject[]**
* IsStarted: **bool** 

### Subject(Domain Model Class):
* **(constructor)** Takes (*name*, *classes*) as parameters, **Students** should be empty array, **IsStarted** should be false
* **(constructor)** Takes (*name*, *classes*, *students*) as parameters, **IsStarted** should be false
* Name: **string**
* Classes: **int** (number of classes)
* Students: **Student[]**
* IsStarted: **bool**

### Student(Domain Model Class):
* **(no constructors)**
* Name: **string**
* LastName: **string**
* Age: **int**
* CardNumber: **int**

### AcademyService(Service Class):
* StartAcademy(**Academy** academy) => **void**
* EndAcademy(**Academy** academy) => **void**
* StartSubject(**Academy** academy, **string** subjectName) => **void**
* EndSubject(**Academy** academy, **string** subjectName) => **void**
* AddStudentToSubject(**Subject** subject, **Student** student) => **void**
* AddSubjectToAcademy(**Academy** academy, **Subject** subject) => **void**
* CreateStudent(**string** name, **string** lastName, **int** age, **int** cardNumber) => **Student**

# Task 2

* Add **CurrentSubject** property in **Student** and make it work in correlation with **StartSubject** method
* Make a UI that will the user for his Name, Lastname, Age and which academy he wants to start
* Start the first subject of that academy and put the student in the array of students to the started subject