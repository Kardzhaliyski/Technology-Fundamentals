using System;
using System.Linq;
using System.Collections.Generic;

class ListOperations
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();


        while (true)
        {
            string[] tokens = Console.ReadLine()
                .Split();
            string command = tokens[0];

            if (command == "End")
            {
                break;
            }

            if (command == "Add")
            {
                int number = int.Parse(tokens[1]);
                numbers.Add(number);
            }

            else if (command == "Insert")
            {
                int number = int.Parse(tokens[1]);
                int index = int.Parse(tokens[2]);
                if (IsValidIndex(numbers, index))
                {
                    numbers.Insert(index, number);
                }
                else
                {
                    Console.WriteLine("Invalid index");
                }

            }

            else if (command == "Remove")
            {
                int index = int.Parse(tokens[1]);

                if (IsValidIndex(numbers, index))
                {
                    numbers.RemoveAt(index);
                }
                else
                {
                    Console.WriteLine("Invalid index");
                }
            }

            else if (command == "Shift")
            {
                string direction = tokens[1];
                int times = int.Parse(tokens[2]);

                if (direction == "left")
                {
                    RotateLeft(numbers, times);
                }

                else if (direction == "right")
                {
                    RotateRight(numbers, times);
                }
            }


        }

        Console.WriteLine(string.Join(' ', numbers));
    }

    private static void RotateRight(List<int> numbers, int times)
    {
        int lastIndex = numbers.Count - 1;

        for (int rotation = 0; rotation < times; rotation++)
        {

            int lastNumber = numbers[lastIndex];

            for (int i = numbers.Count - 1; i >= 1; i--)
            {
                numbers[i] = numbers[i - 1];
            }

            numbers[0] = lastNumber;
        }
    }

    private static void RotateLeft(List<int> numbers, int times)
    {

        int lastIndex = numbers.Count - 1;

        for (int rotation = 0; rotation < times; rotation++)
        {
            int firstNum = numbers[0];
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                numbers[i] = numbers[i + 1];
            }

            numbers[lastIndex] = firstNum;
        }
    }

    private static bool IsValidIndex(List<int> array, int index)
    {
        if (index >= array.Count || index < 0)
        {
            return false;
        }
        return true;
    }
}

