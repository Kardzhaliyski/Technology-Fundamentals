using System;

namespace MiddleCharacter
{
    class MiddleCharacter
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            PrintMiddleCharacter(text);

        }

        public static void PrintMiddleCharacter(string text)
        {
            if(text.Length % 2 == 1)
            {
                int midCharIndex = text.Length / 2;
                Console.WriteLine(text[midCharIndex]);
            }
            else
            {
                int midCharIndex = (text.Length / 2) - 1;
                Console.Write(text[midCharIndex]);
                Console.WriteLine(text[midCharIndex +1]);
            }
        }
    }
}
