using System;
using System.Linq;

class EqualSums
{
    static void Main(string[] args)
    {
        int[] array = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();
        bool foundEqual = false;

        for (int i = 0; i < array.Length; i++)
        {
            if(sumOnLeft(array, i) == sumOnRight(array, i))
            {
                Console.Write(i + " ");
                foundEqual = true;
            }
        }

        if (!foundEqual)
        {
            Console.WriteLine("no");
        }

    }

    public static int sumOnLeft(int[] array, int currIndex)
    {
        int sum = 0;
        for (int i = 0; i < currIndex; i++)
        {
            sum += array[i];
        }
        return sum;

    }

    public static int sumOnRight(int[] array, int currIndex)
    {
        int sum = 0;
        for (int i = array.Length - 1; i > currIndex; i--)
        {
            sum += array[i];
        }
        return sum;
    }
}

