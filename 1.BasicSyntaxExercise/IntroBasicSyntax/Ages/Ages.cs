using System;


class Ages
{
    static void Main(string[] args)
    {
        int age = int.Parse(Console.ReadLine());

        if (age >= 66)
        {
            Console.WriteLine("elder");
        }
        else if (age >= 20)
        {
            Console.WriteLine("adult");
        }
        else if (age >= 14)
        {
            Console.WriteLine("teenager");
        }
        else if (age >= 3)
        {
            Console.WriteLine("child");
        }
        else if (age >= 0)
        {
            Console.WriteLine("baby");
        }

    }
}

