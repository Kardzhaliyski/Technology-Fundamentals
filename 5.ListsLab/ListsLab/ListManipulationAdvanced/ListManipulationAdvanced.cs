using System;
using System.Collections.Generic;
using System.Linq;


class ListManipulationAdvanced
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

        bool madeChanges = false;

        while (true)
        {
            string[] input = Console.ReadLine()
                .Split();
            string command = input[0];

            if (command == "end")
            {
                break;
            }

            if (command == "Add")
            {
                int number = int.Parse(input[1]);
                numbers.Add(number);
                madeChanges = true;
            }

            else if (command == "Remove")
            {
                int number = int.Parse(input[1]);
                numbers.Remove(number);
                madeChanges = true;

            }

            else if (command == "RemoveAt")
            {
                int index = int.Parse(input[1]);
                numbers.RemoveAt(index);
                madeChanges = true;
            }

            else if (command == "Insert")
            {
                int number = int.Parse(input[1]);
                int index = int.Parse(input[2]);
                madeChanges = true;
                numbers.Insert(index, number);
            }

            else if (command == "Contains")
            {
                int number = int.Parse(input[1]);
                Console.WriteLine(numbers.Contains(number) ? "Yes" : "No such number");
            }

            else if (command == "PrintEven")
            {
                var evenNumbers = numbers.Where(n => n % 2 == 0);
                Console.WriteLine(string.Join(' ', evenNumbers));
            }

            else if (command == "PrintOdd")
            {
                var evenNumbers = numbers.Where(n => n % 2 == 1);
                Console.WriteLine(string.Join(' ', evenNumbers));
            }

            else if (command == "GetSum")
            {
                Console.WriteLine(numbers.Sum());
            }

            else if (command == "Filter")
            {
                PrintFilter(numbers, input);
            }
        }
        if (madeChanges)
        {
            Console.WriteLine(string.Join(' ', numbers));
        }

    }

    public static void PrintFilter(List<int> array, string[] input)
    {
        string condition = input[1];
        int number = int.Parse(input[2]);

        if (condition == ">")
        {
            var numbers = array.Where(n => n > number);
            Console.WriteLine(string.Join(' ', numbers));
        }
        else if (condition == ">=")
        {
            var numbers = array.Where(n => n >= number);
            Console.WriteLine(string.Join(' ', numbers));
        }
        else if (condition == "==")
        {
            var numbers = array.Where(n => n == number);
            Console.WriteLine(string.Join(' ', numbers));
        }
        else if (condition == "<=")
        {
            var numbers = array.Where(n => n <= number);
            Console.WriteLine(string.Join(' ', numbers));
        }
        else if (condition == "<")
        {
            var numbers = array.Where(n => n < number);
            Console.WriteLine(string.Join(' ', numbers));
        }
    }

}

