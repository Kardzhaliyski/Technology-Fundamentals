using System;
using System.Collections.Generic;
using System.Linq;

class BombNumbers
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        int[] bombNumberInput = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int bombNumber = bombNumberInput[0];
        int firePower = bombNumberInput[1];

        while (numbers.Contains(bombNumber))
        {
            Explode(numbers, bombNumber, firePower);
        }

        Console.WriteLine(numbers.Sum());
    }

    private static void Explode(List<int> numbers, int bombNumber, int firePower)
    {
        int bombIndex = numbers.IndexOf(bombNumber);
        int firstBlownNumberIndex = bombIndex - firePower;
        int totalBlownNumbers = firePower * 2 + 1;

        if(firstBlownNumberIndex < 0)
        {
            totalBlownNumbers += firstBlownNumberIndex;
            firstBlownNumberIndex = 0;
        }

        if(firstBlownNumberIndex + totalBlownNumbers > numbers.Count)
        {
            totalBlownNumbers = numbers.Count - firstBlownNumberIndex;
        }

        numbers.RemoveRange(firstBlownNumberIndex, totalBlownNumbers);

    }
}

