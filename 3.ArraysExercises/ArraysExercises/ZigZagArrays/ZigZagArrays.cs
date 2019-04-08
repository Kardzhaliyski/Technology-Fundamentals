using System;
using System.Linq;

class ZigZagArrays
{
    static void Main(string[] args)
    {
        int arrLengths = int.Parse(Console.ReadLine());
        int[] arr1 = new int[arrLengths];
        int[] arr2 = new int[arrLengths];

        for (int i = 0; i < arrLengths; i++)
        {
            int[] tempArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            if(i % 2 == 0)
            {
                arr1[i] = tempArr[0];
                arr2[i] = tempArr[1];
            }
            else
            {
                arr1[i] = tempArr[1];
                arr2[i] = tempArr[0];
            }
        }

        foreach (var num in arr1)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
        foreach (var num in arr2)
        {
            Console.Write(num + " ");
        }
    }
}

