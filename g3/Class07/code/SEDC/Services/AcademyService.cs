using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class AcademyService
    {
        public void StartAcademy(Academy academy)
        {
            if (!academy.IsStarted)
                academy.IsStarted = true;
        }

        public void EndAcademy(Academy academy)
        {
            if (academy.IsStarted)
                academy.IsStarted = false;
        }

        public void StartSubject(Academy academy, string subjectName)
        {

        }

        public void EndSubject(Academy academy, string subjectName)
        {

        }

        public void AddStudentToSubject(Subject subject, Student student)
        {

        }

        public void AddSubjectToAcademy(Academy academy, Subject subject)
        {

        }

        public Student CreateStudent(string name, string lastName, int age, int cardNumber)
        {
            //Student student = new Student();
            //student.Name = name;
            //student.LastName = lastName;
            //student.Age = age;
            //student.CardNumber = cardNumber;

            Student student = new Student
            {
                Name = name,
                LastName = lastName,
                Age = age,
                CardNumber = cardNumber
            };

            return student;
        }
    }
}
