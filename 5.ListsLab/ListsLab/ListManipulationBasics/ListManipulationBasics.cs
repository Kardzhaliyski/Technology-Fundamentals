using System;
using System.Collections.Generic;
using System.Linq;

class ListManipulationBasics
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToList();

        while (true)
        {
            string[] input = Console.ReadLine()
                .Split();
            string command = input[0];

            if(command == "end")
            {
                break;
            }

            if(command == "Add")
            {
                int number = int.Parse(input[1]);
                numbers.Add(number);
            }

            else if(command == "Remove")
            {
                int number = int.Parse(input[1]);
                numbers.Remove(number);
            }

            else if(command == "RemoveAt")
            {
                int index = int.Parse(input[1]);
                numbers.RemoveAt(index);
            }

            else if(command == "Insert")
            {
                int number = int.Parse(input[1]);
                int index = int.Parse(input[2]);
                numbers.Insert(index, number);
            }
        }

        Console.WriteLine(string.Join(' ', numbers));

    }
}

