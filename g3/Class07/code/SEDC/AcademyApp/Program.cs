using System;
using Domain;
using Services;

namespace AcademyApp
{
    class Program
    {
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
            Subject htmlCss = new Subject("HTML/CSS", 10);
            Subject javaScriptBasic = new Subject("Basic JavaScript", 10, jsBasicStudents);
            Subject javaScriptAdvanced = new Subject("Advanced JavaScript", 15, jsAdvancedStudents);
            Subject cSharpBasic = new Subject("Basic C#", 10);
            Subject cSharpAdvanced = new Subject("Advanced C#", 15);

            Subject[] webSubjects = new Subject[] { htmlCss, javaScriptBasic, javaScriptAdvanced, cSharpBasic };


            // Academy
            Academy web = new Academy("Web", "Full Stack Web Development", webSubjects);



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
            Subject drawing = new Subject("Drawing", 5);
            Subject photoshop = new Subject("Photoshop", 10, photoshopStudents);
            Subject ilustrator = new Subject("Ilustrator", 15, ilustratorStudents);
            Subject art = new Subject("Art", 10);

            Subject[] designSubjects = new Subject[] { drawing, photoshop, art };



            // Academy
            Academy design = new Academy("Web", "Full Stack Web Development", designSubjects);



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
    }
}
