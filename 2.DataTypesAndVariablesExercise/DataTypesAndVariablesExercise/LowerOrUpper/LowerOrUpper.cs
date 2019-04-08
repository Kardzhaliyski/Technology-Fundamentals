using System;


class LowerOrUpper
{
    static void Main(string[] args)
    {
        char character = char.Parse(Console.ReadLine());
        if(character >= 'a')
        {
            Console.WriteLine("lower-case");
        }
        else
        {
            Console.WriteLine("upper-case");
        }

    }
}

