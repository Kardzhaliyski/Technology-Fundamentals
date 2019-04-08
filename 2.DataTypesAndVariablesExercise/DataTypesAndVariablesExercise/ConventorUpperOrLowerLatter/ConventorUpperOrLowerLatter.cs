using System;


class ConventorUpperOrLowerLatter
{
    static void Main(string[] args)
    {
        char character = char.Parse(Console.ReadLine());
        if (character >= 'a')
        {
            character = (char)(character - 32);
        }
        else
        {
            character = (char)(character + 32);
        }
        Console.WriteLine(character);
    }
}

