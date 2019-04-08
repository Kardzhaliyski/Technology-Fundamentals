using System;
using System.Linq;
using System.Collections.Generic;


class ChangeList
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        while (true)
        {
            string input = Console.ReadLine();

            if(input == "end")
            {
                break;
            }

            string[] tokens = input.Split();

            if(tokens[0] == "Delete")
            {
                int element = int.Parse(tokens[1]);
                numbers.RemoveAll(x => x == element);
            }

            else if(tokens[0] == "Insert")
            {
                int element = int.Parse(tokens[1]);
                int insertIndex = int.Parse(tokens[2]);
                numbers.Insert(insertIndex, element);
            }
        }

        Console.WriteLine(string.Join(' ', numbers));
    }

}

