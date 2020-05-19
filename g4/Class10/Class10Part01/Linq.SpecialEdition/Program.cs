using Linq.SpecialEdition.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Linq.SpecialEdition
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student("John", "Doe", 22, "G1", 'M', new List<string>(){"C#", "SQL"}),
                new Student("Anna", "Bakers", 31, "G3", 'F', new List<string>(){"Javascript", "Docker"}),
                new Student("Tanya", "Walters", 24, "G2", 'F', new List<string>(){"Java", "Docker"}),
                new Student("Tim", "Yung", 26, "G1", 'M', new List<string>(){"React", "CSS"}),
                new Student("Kathy", "Donovan", 19, "G4", 'F', new List<string>(){"C#", "SQL"}),
                new Student("James", "Hughs", 36, "G3", 'M', new List<string>(){"C#", "React", "SQL", "Vue"}),
                new Student("Trey", "Anders", 27, "G2", 'M', new List<string>(){"Javascript", "CSS"}),
                new Student("Diana", "Jones", 30, "G4", 'F', new List<string>(){"CSS", "HTML"}),
                new Student("Eric", "White", 20, "G1", 'M', new List<string>(){"SQL", "React"}),
                new Student("Angela", "Johnson", 28, "G2", 'F', new List<string>(){"React", "Javascript", "CSS", "Vue"}),
                new Student("Chris", "Peterson", 25, "G1", 'M', new List<string>(){"C#", "SQL", "Docker"}),
            };

            // METHOD SYNTAX OF WRITING LINQ


            // Task 01 - find AGE of youngest and oldest student
            Console.WriteLine(" =========== MAX / MIN ================");
            int youngestAge = students
                                    .Select(st => st.Age)
                                    .Min();

            
            var oldestAge = students
                                    .Select(st => st.Age)
                                    .Max();
            Console.WriteLine("Age of youngest student is {0} and of oldest {1}", youngestAge, oldestAge);
            
            // get the whole Student object with nested linq methods
            var youngest = students
                                   .FirstOrDefault(st => st.Age == students
                                    .Select(stud => stud.Age)
                                    .Min());

            Console.WriteLine("Name of yougest is {0}", youngest.Firstname);
            // 22, 31, 24, 35, ...


            // Task 02 - find SUM of all ages of all students
            Console.WriteLine(" =========== SUM ================");

            int sumOfAges = students
                                .Select(st => st.Age)
                                .Sum();
            Console.WriteLine($"Sum af ages of students is {sumOfAges}");

            // Task 03 - find AVERAGE of all ages of all students
            Console.WriteLine(" =========== AVERAGE ================");

            double averageAge = students
                                .Select(st => st.Age)
                                .Average();
            Console.WriteLine("Average age of all students is {0:0.##}", averageAge);

            // Task 04 - order students by name in ascending order / descending order
            Console.WriteLine(" =========== ORDER BY (ASCENDING) ================");

            List<Student> ascendingOrder = students
                                    .OrderBy(st => st.Firstname)
                                    .ToList();
            ascendingOrder.ForEach(st => Console.WriteLine(st.Firstname));

            Console.WriteLine(" =========== ORDER BY (DESCENDING) ================");

            List<Student> descendingOrder = students
                                            .OrderByDescending(st => st.Firstname)
                                            .ToList();
            descendingOrder.ForEach(st => Console.WriteLine(st.Firstname));

            // Task 05 - group elements by group
            Console.WriteLine(" =========== GROUP BY ================");
            Dictionary<string, List<Student>> studentDictionary = new Dictionary<string, List<Student>>();
            
            var groupedStudents = students
                                        .OrderBy(st => st.Group)
                                        .GroupBy(st => st.Group);
            // { "G1": IEnumerable<Student> { st1, st2,...}.ToList()}
            // { "G2": IEnumerable<Student> { st1, st2,...}}
            // { "G3": ......}
            // { "G4: ........}

            foreach (var item in groupedStudents)
            {
                studentDictionary.Add(item.Key, item.ToList());
            }

            List<Student> g4 = null;
            bool areThereAnyStInG4 = studentDictionary.TryGetValue("G4", out g4);

            Console.WriteLine(areThereAnyStInG4 == false ? "No students in G4" : $"Number of students in G4 are {g4.Count}");
            // this is same as
            if(areThereAnyStInG4 == false)
            {
                Console.WriteLine("No students in G4");
            } else
            {
                Console.WriteLine($"Number of students in G4 are {g4.Count}");
            }

            // more fancy
            Console.WriteLine(!areThereAnyStInG4 ? "No students in G4" : $"Number of students in G4 are {g4.Count}");


            // Task 06 - find person with most skills
            Console.WriteLine(" =========== FIRSTORDEFAULT / SINGLEORDEFAULT ================");

            int mostSkills = students
                                .Select(st => st.Skills.Count)
                                .Max();

            Student mostSkilledStudent01 = students
                                                .Where(st => st.Skills.Count == mostSkills)
                                                .FirstOrDefault();

            Student mostSkilledStudent00 = students
                                                .Where(st => st.Skills.Count == students.Select(stud => stud.Skills.Count).Max())
                                                .FirstOrDefault();

            Student mostSkilledStudent02 = students
                                                .FirstOrDefault(st => st.Skills.Count == students.Select(stud => stud.Skills.Count).Max());

            //Student mostSkilledStudent03 = students
            //                                    .SingleOrDefault(st => st.Skills.Count == students.Select(stud => stud.Skills.Count).Max());
            // this will throw an exception because there are more than one result


            Console.WriteLine($"Most skilled student is: {mostSkilledStudent00.Firstname}");
            Console.WriteLine($"Most skilled student is: {mostSkilledStudent01.Firstname}");
            Console.WriteLine($"Most skilled student is: {mostSkilledStudent02.Firstname}");
            // Console.WriteLine($"Most skilled student is: {mostSkilledStudent03.Firstname}");

            // FirstOrDefault() returns a first item of potentially multiple (or default - null if none exists)
            // SingleOrDefault() assumes that is a single item and returns it (or default - null if none exists). 
            // Multiple items are a violation of contract, an exception is thrown.


            // QUERY SYNTAX OF WRITING LINQ
            var mostSkilledQuery = from st in students
                                   where st.Skills.Count == mostSkills
                                   select st.Firstname;
            // "James", "Angela"
            Console.WriteLine(mostSkilledQuery.FirstOrDefault());

            var youngerThan30 = from st in students
                                where st.Age < 30
                                select st.Firstname;
            // "name", "name2", "name3"
            Console.WriteLine(youngerThan30.FirstOrDefault());

            Console.ReadLine();
        }
    }
}
