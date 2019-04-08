using System;
using System.Collections.Generic;
using System.Linq;

class SoftUniCoursePlanning
{
    static void Main(string[] args)
    {
        List<string> course = Console.ReadLine()
            .Split(", ")
            .ToList();

        while (true)
        {
            string command = Console.ReadLine();
            if (command == "course start")
            {
                break;
            }

            string[] tokens = command
                .Split(':');
            string action = tokens[0];
            if (action == "Add")
            {
                string lessonTitle = tokens[1];
                AddLesson(course, lessonTitle);
            }

            else if (action == "Insert")
            {
                string lessonTitle = tokens[1];
                int index = int.Parse(tokens[2]);
                InsertLesson(course, lessonTitle, index);
            }

            else if (action == "Remove")
            {
                string lessonTitle = tokens[1];
                RemoveLesson(course, lessonTitle);
            }

            else if (action == "Swap")
            {
                string lessonTitle1 = tokens[1];
                string lessonTitle2 = tokens[2];
                Swap(course, lessonTitle1, lessonTitle2);
            }

            else if (action == "Exercise")
            {
                string lessonTitle = tokens[1];
                AddExercise(course, lessonTitle);
            }

        }

        PrintCourse(course);

    }

    private static void PrintCourse(List<string> course)
    {
        for (int i = 0; i < course.Count; i++)
        {
            Console.WriteLine($"{i+1}.{course[i]}");
        }
    }

    private static void AddExercise(List<string> course, string lessonTitle)
    {
        string exerciseName = lessonTitle + "-Exercise";
        if (course.Contains(exerciseName))
        {
            return;
        }

        else if (course.Contains(lessonTitle))
        {
            int lessonIndex = course.IndexOf(lessonTitle);
            course.Insert(lessonIndex + 1, exerciseName);
        }

        else
        {
            course.Add(lessonTitle);
            course.Add(exerciseName);
        }

        return;
    }

    private static void Swap(List<string> course, string lessonTitle1, string lessonTitle2)
    {
        if(course.Contains(lessonTitle1) && course.Contains(lessonTitle2))
        {
            int lesson1Index = course.IndexOf(lessonTitle1);
            int lesson2Index = course.IndexOf(lessonTitle2);
            course[lesson1Index] = lessonTitle2;
            course[lesson2Index] = lessonTitle1;
            lesson1Index = course.IndexOf(lessonTitle1);
            lesson2Index = course.IndexOf(lessonTitle2);

            string exercise1Name = lessonTitle1 + "-Exercise";
            if (course.Contains(exercise1Name))
            {
                course.Remove(exercise1Name);
                course.Insert(lesson1Index + 1, exercise1Name);
            }

            string exercise2Name = lessonTitle2 + "-Exercise";
            if (course.Contains(exercise2Name))
            {
                course.Remove(exercise2Name);
                course.Insert(lesson2Index + 1, exercise2Name);
            }
        }

        else
        {
            return;
        }
    }

    private static void RemoveLesson(List<string> course, string lessonTitle)
    {
        int index = course.IndexOf(lessonTitle);
        string exerciseTitle = lessonTitle + "-Exercise";
        course.Remove(lessonTitle);
        course.Remove(exerciseTitle);
        return;
    }

    private static void InsertLesson(List<string> course, string lessonTitle, int index)
    {
        if (course.Contains(lessonTitle) == false)
        {
            course.Insert(index, lessonTitle);
            return;
        }
    }

    private static void AddLesson(List<string> course, string lessonTitle)
    {
        if (course.Contains(lessonTitle) == false)
        {
            course.Add(lessonTitle);
            return;
        }
    }
}

