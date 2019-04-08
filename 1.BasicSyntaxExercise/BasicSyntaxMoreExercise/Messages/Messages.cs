using System;


class Messages
{
    static void Main(string[] args)
    {
        int wordLength = int.Parse(Console.ReadLine());
        string message = "";

        for (int i = 0; i < wordLength; i++)
        {
            string currChar = Console.ReadLine();
            int digit = (int)Char.GetNumericValue(currChar[0]);
            int charIndex = ((digit - 2) * 3) + currChar.Length -1;

            if(digit == 8 || digit == 9)
            {
                charIndex += 1;
            }

            if(digit == 0)
            {
                message += " ";
                continue;
            }
            message += (char)('a' + charIndex);

        }
        Console.WriteLine(message);
        
    }
}

