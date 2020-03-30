using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Length
            // ToLower()
            // ToUpper()

            string groupFeedback = "C# is GREAT programming language!";

            int numberOfCharactersInTheString = groupFeedback.Length;

            Console.WriteLine($@"The length of {groupFeedback} ""STRING"" is {groupFeedback.Length} characters");

            Console.WriteLine("All letters smaller: {0}", groupFeedback.ToLower());
            Console.WriteLine("All letter CAPITAL" + groupFeedback.ToUpper());

            // Trim()
            // TrimStart()
            // TrimEnd()
            // Cut EMPTY SPACES in the beggining or at the end of the string

            string gitUsername = "           miodragc      ";
            Console.WriteLine("Git username: " + gitUsername.Length); //25

            string gitUsernameTrimmed = gitUsername.Trim();
            Console.WriteLine($"Git username length with Trim() is: {gitUsernameTrimmed.Length}"); //8

            string gitUsernameTrimmedStart = gitUsername.TrimStart();
            string gitUsernameTrimmedEnd = gitUsername.TrimEnd();

            Console.WriteLine("Please enter your username and password:");

            // StartWith()
            // EndsWith()
            // IndexOf() - String method

            string academySubjects = "HTML, CSS, Java Script, C#";

            string html = "HTML ";

            bool htmlIsFirstSubject = academySubjects.StartsWith("HTML");
            bool htmlIsFirstSubjectWithSpace = academySubjects.StartsWith(html.Trim());
            bool cSharpIsCurrentSubject = academySubjects.EndsWith("C#");
            var indexOfJavaScript = academySubjects.IndexOf("Java Script");

            Console.WriteLine($"HTML: {htmlIsFirstSubject}, C#: {cSharpIsCurrentSubject}, Java Script with index {indexOfJavaScript}");

            // Substring()

            //Get all subjects from SEDC, except HTML
            string allsSubjectsExceptHTML = academySubjects.Substring(6);
            Console.WriteLine("All subjects from SEDC without the HTML are: " + allsSubjectsExceptHTML);

            string cssSubject = academySubjects.Substring(6, 3);
            Console.WriteLine("Only CSS is----" + cssSubject);

            // Action point - Miodrag to think about Word processor :)

            // Split() - FANTASTIC!!!!   
            // string[]

            string academySubjectsAgaing = "HTML, CSS, Java Script, C#";

            string[] subjects = academySubjectsAgaing.Split(", ");

            //subjects = ["HTML", "CSS", "Java Script", "C#"] - SPLIT!!

            // HTML
            // CSS
            // Java Script
            
            string join = "";
            foreach (var subject in subjects)
            {
                join += subject + ", ";
            }

            // ToCharArray() - LIKE * LIKE
            // char[]

            char[] characters = academySubjectsAgaing.ToCharArray();
            // characters = ['H', 'T', 'M', 'L', .....]


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(characters[0]);

            foreach (var character in characters)
            {
                Console.WriteLine(character);
            }

            Console.ReadLine();
        }
    }
}
