using System;
using System.Linq;

class TopIntegers
{
    static void Main(string[] args)
    {
        int[] array = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        for (int i = 0; i < array.Length; i++)
        {
            if(IsStrong(array, i))
            {
                Console.Write(array[i] + " ");
            }
        }
    }

    static bool IsStrong(int[] array, int currIndex)
    {
        for (int i = currIndex + 1; i < array.Length; i++)
        {
            if (array[currIndex] <= array[i])
            {
                return false;
            }
        }
        return true;


    }
}

