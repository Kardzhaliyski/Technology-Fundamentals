using System;

class TripleLetters
{
    static void Main(string[] args)
    {
        int lastLetter = int.Parse(Console.ReadLine());
        char lastLetterIndex = (char)('a' + lastLetter);

        for (char firstRow = 'a'; firstRow < lastLetterIndex; firstRow++)
        {
            for (char secRow = 'a'; secRow < lastLetterIndex; secRow++)
            {
                for (char thirdRow = 'a'; thirdRow < lastLetterIndex; thirdRow++)
                {
                    Console.WriteLine($"{firstRow}{secRow}{thirdRow}");
                }
            }
        }

    }
}

