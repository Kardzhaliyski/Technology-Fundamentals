using System;


class StringRepeater
{
    static void Main(string[] args)
    {
        string inputString = Console.ReadLine();
        int count = int.Parse(Console.ReadLine());
        string newString = RepeatAString(inputString, count);
        Console.WriteLine(newString);

    }

    public static string RepeatAString(string inpString, int count)
    {
        string newString = inpString;
        for (int i = 1; i < count; i++)
        {
            newString += inpString;
        }

        return newString;
    }
}

