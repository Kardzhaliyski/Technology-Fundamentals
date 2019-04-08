using System;

namespace ReplaceRepeatingChars
{
    class ReplaceRepeatingChars
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            string newString = inputString[0].ToString();

            for (int i = 1; i < inputString.Length; i++)
            {
                if (inputString[i] != inputString[i - 1])
                {
                    newString += inputString[i];
                }

            }

            Console.WriteLine(newString);
        }
    }
}
