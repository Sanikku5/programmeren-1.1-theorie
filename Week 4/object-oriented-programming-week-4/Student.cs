using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_programming_week_4
{
    public class Student
    {
        string firstName, lastName;
        int studentNumber;
        string email;

        public Student(string firstName, string lastName, int studentNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.studentNumber = studentNumber;
            this.email = $"{studentNumber}@student.inholland.nl";
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Student {firstName} {lastName} has studentnumber: {studentNumber} and email: {email}");
        }

        public void UpdateFirstName(string firstName)
        {
            this.firstName = firstName;
        }
    }
}
