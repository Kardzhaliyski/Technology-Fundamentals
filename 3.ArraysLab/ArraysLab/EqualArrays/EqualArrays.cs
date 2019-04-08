using System;
using System.Linq;

class EqualArrays
{
    static void Main(string[] args)
    {
        int[] arrInts1 = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int[] arrInts2 = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int sum = 0;

        for (int i = 0; i < arrInts1.Length; i++)
        {
            if(arrInts1[i] == arrInts2[i])
            {
                sum += arrInts1[i];
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                return;
            }
        }

        Console.WriteLine($"Arrays are identical. Sum: {sum}");
    }
}

