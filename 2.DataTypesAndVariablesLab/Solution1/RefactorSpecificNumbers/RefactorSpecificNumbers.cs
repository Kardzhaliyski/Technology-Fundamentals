using System;


class RefactorSpecificNumbers
{
    static void Main(string[] args)
    {
        int endNum = int.Parse(Console.ReadLine());
        for (int currNum = 1; currNum <= endNum; currNum++)
        {
            int tempNum = currNum;
            int currSum = 0;
            while (tempNum > 0)
            {
                currSum += tempNum % 10;
                tempNum = tempNum / 10;
            }
            bool isSpecial = (currSum == 5) || (currSum == 7) || (currSum == 11);
            Console.WriteLine($"{currNum} -> {isSpecial}");
        }

    }
}

