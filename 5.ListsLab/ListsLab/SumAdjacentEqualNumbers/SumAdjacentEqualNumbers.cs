using System;
using System.Collections.Generic;
using System.Linq;


class SumAdjacentEqualNumbers
{
    static void Main(string[] args)
    {
        List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

        SumAdjEqualNumbers(numbers);

        Console.WriteLine(string.Join(' ', numbers));
    }

    public static void SumAdjEqualNumbers(List<double> numbers)
    {
        bool sumThisCicle = true;
        while (sumThisCicle)
        {
            sumThisCicle = false;
            for (int curIndex = 0; curIndex < numbers.Count -1; curIndex++)
            {
                if (numbers[curIndex] == numbers[curIndex + 1])
                {
                    numbers[curIndex] = numbers[curIndex] * 2;
                    numbers.RemoveAt(curIndex + 1);
                    sumThisCicle = true;
                }
            }
        }
    }
}

