using System;


class MultiplicationTable
{
    static void Main(string[] args)
    {
        int inpNum = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{inpNum} X {i} = {inpNum*i}");
        }

    }
}

