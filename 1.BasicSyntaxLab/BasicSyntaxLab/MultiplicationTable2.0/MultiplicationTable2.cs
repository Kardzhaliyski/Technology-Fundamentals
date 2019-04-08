using System;


class MultiplicationTable2
{
    static void Main(string[] args)
    {
        int staticLeftNum = int.Parse(Console.ReadLine());
        int changingRightNum = int.Parse(Console.ReadLine());


        for (int i = changingRightNum; i <= 10; i++)
        {
            Console.WriteLine($"{staticLeftNum} X {i} = {staticLeftNum * i}");
        }

        if (changingRightNum > 10)
            Console.WriteLine($"{staticLeftNum} X {changingRightNum} = {staticLeftNum * changingRightNum}");

    }
}
