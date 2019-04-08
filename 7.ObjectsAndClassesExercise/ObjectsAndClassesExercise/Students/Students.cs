using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Students
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            var students = new List<Student>();

            for (int i = 0; i < count; i++)
            {
                var tokens = Console.ReadLine()
                    .Split();
                var firstName = tokens[0];
                var lastName = tokens[1];
                var grade = double.Parse(tokens[2]);
                var student = new Student(firstName,lastName,grade);
                students.Add(student);
            }

            students = students
                .OrderByDescending(x => x.Grade)
                .ToList();
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

        }
    }

    class Student
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:F2}"; 
        }
    }
}
