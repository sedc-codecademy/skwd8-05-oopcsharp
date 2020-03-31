using SEDC.Class06.Excersise.Enumerations;
using SEDC.Execersise.Entities;
using System;

namespace SEDC.Class06.Excersise.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = InitializeStudents();

            Console.WriteLine("Please enter a name of the student: ");
            string inputName = Console.ReadLine();

            Student foundStudent = FindStudentByName(inputName, students);

            PrintStudentInfo(foundStudent);
            
            Console.ReadLine();
        }

        public static Student[] InitializeStudents()
        {
            Student[] students = new Student[]
            {
                new Student("Trajan", Academy.WebDevelopment, Group.Group1),
                new Student("Tosho", Academy.WebDevelopment, Group.Group1),
                new Student("Dragan", Academy.Network, Group.Group2),
                new Student("Damjan", Academy.Desing, Group.Group3),
                new Student("Dejan", Academy.Testing, Group.Group2)
            };
            return students;
        }

        public static Student FindStudentByName(string name, Student[] students)
        {
            foreach (var student in students)
            {
                if (student.Name == name)
                {
                    return student;
                }
            }
            return null;
        }

        public static void PrintStudentInfo(Student student)
        {
            if (student != null)
            {
                Console.WriteLine(student.GetInfo());
            }
            else
            {
                Console.WriteLine("No student was found with that name.");
            }
        }
    }
}
