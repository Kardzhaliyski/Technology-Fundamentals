using System;


class DivisibleBy3
{
    static void Main(string[] args)
    {
        for (int curNum = 1; curNum < 101; curNum++)
        {
            if (curNum % 3 == 0)
                Console.WriteLine(curNum);
        }
    }
}

