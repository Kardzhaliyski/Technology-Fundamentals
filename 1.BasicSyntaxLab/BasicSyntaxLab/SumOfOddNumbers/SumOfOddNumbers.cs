using System;


class SumOfOddNumbers
{
    static void Main(string[] args)
    {
        int nOddNums = int.Parse(Console.ReadLine());
        int oddNumsSum = 0;

        for (int curNum = 1, counter = 0; counter < nOddNums; curNum += 2, counter++)
        {
            oddNumsSum += curNum;
            Console.WriteLine(curNum);
        }
        Console.WriteLine($"Sum: {oddNumsSum}");

    }
}

