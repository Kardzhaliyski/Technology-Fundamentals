using System;


class EvenNumber
{
    static void Main(string[] args)
    {
        int inptNum = int.Parse(Console.ReadLine());

        while (inptNum % 2 != 0)
        {
            Console.WriteLine("Please write an even number.");
            inptNum = int.Parse(Console.ReadLine());
        }

        if(inptNum < 0)
        {
            inptNum *= -1;
        }

        Console.WriteLine($"The number is: {inptNum}");

    }
}

