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

### Copy and paste this code in Program.cs in AcademyApp
```csharp
static void Main(string[] args)
        {
            AcademyService academyService = new AcademyService();

            #region Web Academy

            // Students
            Student max = academyService.CreateStudent("Max", "Harper", 25, 288210);
            Student ashton = academyService.CreateStudent("Ashton", "Tucker", 27, 288210);
            Student carl = academyService.CreateStudent("Carl", "Alexander", 28, 288210);
            Student albert = academyService.CreateStudent("Albert", "Thomas", 21, 288210);
            Student kevin = academyService.CreateStudent("Kevin", "Turner", 30, 288210);
            Student charlotte = academyService.CreateStudent("Charlotte", "Mitchell", 27, 288210);
            Student sawyer = academyService.CreateStudent("Sawyer", "Baker", 21, 288210);
            Student savana = academyService.CreateStudent("Savana", "Holmes", 25, 288210);

            Student[] jsBasicStudents = new Student[] { max, ashton, charlotte, savana };
            Student[] jsAdvancedStudents = new Student[] { max, sawyer, kevin, ashton, savana };


            // Subjects
            Subject htmlCss = new Subject("HTML/CSS", 10, false);
            Subject javaScriptBasic = new Subject("Basic JavaScript", jsBasicStudents, 10, false);
            Subject javaScriptAdvanced = new Subject("Advanced JavaScript", jsAdvancedStudents, 15, false);
            Subject cSharpBasic = new Subject("Basic C#", 10, false);
            Subject cSharpAdvanced = new Subject("Advanced C#", 15, false);

            Subject[] webSubjects = new Subject[] { htmlCss, javaScriptBasic, javaScriptAdvanced, cSharpBasic };


            // Academy
            Academy web = new Academy("Web", "Full Stack Web Development", webSubjects, false);



            // AcademyService
            academyService.StartAcademy(web);
            academyService.AddSubjectToAcademy(web, cSharpAdvanced);
            academyService.AddStudentToSubject(cSharpAdvanced, max);
            academyService.AddStudentToSubject(cSharpAdvanced, carl);
            academyService.AddStudentToSubject(cSharpAdvanced, albert);
            academyService.StartSubject(web, "HTML/CSS");

            #endregion

            #region Design Academy

            // Students
            Student brad = academyService.CreateStudent("Brad", "Cooper", 25, 288210);
            Student stuart = academyService.CreateStudent("Stuart", "Grant", 27, 288210);
            Student derek = academyService.CreateStudent("Derek", "Robinson", 28, 288210);
            Student sofia = academyService.CreateStudent("Sofia", "Foster", 21, 288210);
            Student arnold = academyService.CreateStudent("Arnold", "Phillips", 30, 288210);
            Student chelsea = academyService.CreateStudent("Chelsea", "Ferguson", 27, 288210);

            Student[] photoshopStudents = new Student[] { derek, arnold, chelsea, sofia };
            Student[] ilustratorStudents = new Student[] { brad, derek, chelsea, ashton, sofia };



            // Subjects
            Subject drawing = new Subject("Drawing", 5, false);
            Subject photoshop = new Subject("Photoshop", photoshopStudents, 10, false);
            Subject ilustrator = new Subject("Ilustrator", ilustratorStudents, 15, false);
            Subject art = new Subject("Art", 10, false);

            Subject[] designSubjects = new Subject[] { drawing, photoshop, art };



            // Academy
            Academy design = new Academy("Web", "Full Stack Web Development", designSubjects, false);



            // AcademyService
            academyService.StartAcademy(design);
            academyService.AddSubjectToAcademy(design, ilustrator);
            academyService.AddStudentToSubject(photoshop, stuart);
            academyService.AddStudentToSubject(photoshop, derek);
            academyService.AddStudentToSubject(photoshop, arnold);
            academyService.StartSubject(design, "Photoshop");

            #endregion

            Console.ReadLine();
        }
```