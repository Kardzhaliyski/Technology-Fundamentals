using System;

namespace CharactersInRange
{
    class CharactersInRange
    {
        static void Main(string[] args)
        {
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());
            PrintCharactersInRange(char1, char2);

        }

        public static void PrintCharactersInRange(char char1,char char2)
        {
            for (int currChar = Math.Min(char1,char2) +1; currChar < Math.Max(char1,char2); currChar++)
            {
                Console.Write((char)currChar + " ");
            }
        }
    }
}
