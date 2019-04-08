using System;
using System.Collections.Generic;
using System.Linq;

class Courses
{
    static void Main(string[] args)
    {
        var allCourses = new Dictionary<string, List<string>>();

        while (true)
        {
            string[] tokens = Console.ReadLine()
                .Split(" : ");

            if (tokens[0] == "end")
            {
                break;
            }

            string courseName = tokens[0];
            string studentName = tokens[1];

            Register(allCourses, courseName, studentName);
        }

        PrintCourses(allCourses);
    }

    private static void PrintCourses(Dictionary<string, List<string>> allCourses)
    {
        allCourses = allCourses
            .OrderByDescending(x => x.Value.Count)
            .ToDictionary(x => x.Key, x => x.Value);
        OrderLists(allCourses);
        
        foreach (var course in allCourses)
        {
            string courseName = course.Key;
            Console.WriteLine($"{courseName}: {course.Value.Count}");
            foreach (var student in course.Value)
            {
                Console.WriteLine($"-- {student}");
            }

        }
    }

    private static void Register(Dictionary<string, List<string>> allCourses, string courseName, string studentName)
    {
        if (allCourses.ContainsKey(courseName) == false)
        {
            allCourses.Add(courseName, new List<string>());
        }
        allCourses[courseName].Add(studentName);
    }

    public static void OrderLists(Dictionary<string, List<string>> allCourses)
    {
        var tempDict = new Dictionary<string, List<string>>();
        foreach (var kvp in allCourses)
        {
            string courseName = kvp.Key;
            List<string> students = new List<string>();
            foreach (var student in kvp.Value)
            {
                students.Add(student);
            }
            students = students
                .OrderBy(x => x)
                .ToList();
            tempDict.Add(courseName, students);
        }

        foreach (var kvp in tempDict)
        {
            allCourses[kvp.Key] = kvp.Value;
        }
        
    }
}

