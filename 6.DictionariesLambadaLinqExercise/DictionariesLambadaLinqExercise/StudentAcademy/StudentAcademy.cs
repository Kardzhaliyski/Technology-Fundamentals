using System;
using System.Linq;
using System.Collections.Generic;

namespace StudentAcademy
{
    class StudentAcademy
    {
        static void Main(string[] args)
        {
            int inputCount = int.Parse(Console.ReadLine());
            var studentGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < inputCount; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                
                if(studentGrades.ContainsKey(student) == false)
                {
                    studentGrades[student] = new List<double>();
                }

                studentGrades[student].Add(grade);
            }

            var studentAvarageGrade = new Dictionary<string, double>();

            foreach (var student in studentGrades)
            {
                studentAvarageGrade[student.Key] = student.Value.Average();
            }

            studentAvarageGrade = studentAvarageGrade
                .Where(x => x.Value >= 4.5)
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var student in studentAvarageGrade)
            {
                Console.WriteLine($"{student.Key} -> {student.Value:f2}");
            }

        }
    }
}
