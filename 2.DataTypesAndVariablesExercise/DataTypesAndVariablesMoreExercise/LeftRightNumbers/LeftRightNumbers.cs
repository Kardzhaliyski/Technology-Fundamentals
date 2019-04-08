using System;


class LeftRightNumbers
{
    static void Main(string[] args)
    {
        int numbers = int.Parse(Console.ReadLine());

        for (int i = 0; i < numbers; i++)
        {
            string currNumbers = Console.ReadLine();
            string num1String = "";
            string num2String = "";
            for (int j = 0, currN = 0; j < currNumbers.Length; j++)
            {
                if (currNumbers[j] != ' ' && currN == 0)
                {
                    num1String += currNumbers[j];
                }
                else if (currNumbers[j] == ' ')
                {
                    currN = 1;
                }
                else
                {
                    num2String += currNumbers[j];
                }
            }

            long num1 = long.Parse(num1String);
            long num2 = long.Parse(num2String);
            if (num1 >= num2)
            {
                PrintSumOfNumbers(num1);
            }
            else
            {
                PrintSumOfNumbers(num2);
            }
        }

    }

    private static void PrintSumOfNumbers(long num1)
    {
        if (num1 < 0)
            num1 *= -1;
        long sum = 0;
        while (num1 > 0)
        {
            sum += num1 % 10;
            num1 /= 10;
        }
        Console.WriteLine(sum);
    }
}

