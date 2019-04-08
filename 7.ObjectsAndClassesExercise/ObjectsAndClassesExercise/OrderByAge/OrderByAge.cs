using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByAge
{
    class OrderByAge
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                string inputStudentInfo = Console.ReadLine();
                if (inputStudentInfo == "End")
                {
                    break;
                }

                AddStudent(students, inputStudentInfo);
            }

            students = students
                .OrderBy(s => s.Age)
                .ToList();

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name} with ID: {student.Id} is {student.Age} years old.");
            }

        }

        private static void AddStudent(List<Student> students, string inputStudentInfo)
        {
            string[] tokens = inputStudentInfo
                .Split();
            var name = tokens[0];
            var id = tokens[1];
            var age = tokens[2];

            Student student = new Student(name,id,age);
            students.Add(student);
        }

        class Student
        {
            public Student(string name, string id, string age)
            {
                Name = name;
                Id = id;
                Age = int.Parse(age);
            }

            public string Name { get; set; }
            public string Id { get; set; }
            public int Age { get; set; }
        }
    }
}
