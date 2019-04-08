using System;

namespace Substring
{
    class Substring
    {
        static void Main(string[] args)
        {
            string toRemove = Console.ReadLine().ToLower();
            string text = Console.ReadLine().ToLower();
            while (text.Contains(toRemove))
            {
                int indexToRemoveFrom = text.IndexOf(toRemove);
                int toRemoveLength = toRemove.Length;
                text = text.Remove(indexToRemoveFrom, toRemoveLength);
            }

            Console.WriteLine(text);
        }
    }
}
