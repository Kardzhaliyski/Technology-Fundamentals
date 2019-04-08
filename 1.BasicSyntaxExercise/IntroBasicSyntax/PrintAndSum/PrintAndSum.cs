using System;


class PrintAndSum
{
    static void Main(string[] args)
    {
        int firstNum = int.Parse(Console.ReadLine());
        int lastNum = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int curNum = firstNum; curNum <= lastNum;curNum++)
        {
            Console.Write(curNum + " ");
            sum += curNum;
        }
        Console.WriteLine();
        Console.WriteLine($"Sum: {sum}");

    }
}

