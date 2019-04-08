using System;


class StrongNumber
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        int sumF = 0;

        for (int i = 0; i < num.ToString().Length; i++)
        {
            int curNum = num;
            int curF = 1;

            for (int del = 0; del < i; del++)
            {
                curNum /= 10;
            }
            curNum %= 10;

            for (int j = 2; j <= curNum; j++)
            {
                curF *= j;
            }
            sumF += curF;
        }

        if (num == sumF)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }

    }
}

