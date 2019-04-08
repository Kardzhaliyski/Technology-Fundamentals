using System;


class ReverseString
{
    static void Main(string[] args)
    {
        string inpString = Console.ReadLine();
        string revString = "";

        for (int i = 0; i < inpString.Length; i++)
        {
            revString += inpString[(inpString.Length -1 -i)];
        }
        Console.WriteLine(revString);

    }
}

