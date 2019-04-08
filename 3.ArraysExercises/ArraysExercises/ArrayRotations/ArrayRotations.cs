using System;
using System.Linq;

class ArrayRotations
{
    static void Main(string[] args)
    {
        int[] array = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        int rotations = int.Parse(Console.ReadLine());

        RotateArray(array, rotations);

        foreach (var num in array)
        {
            Console.Write(num + " ");
        }

    }

    public static void RotateArray(int[] array, int rotations)
    {
        for (int i = 0; i < rotations; i++)
        {
            int firstNum = array[0];
            for (int currIndx = 0; currIndx < array.Length -1; currIndx++)
            {
                array[currIndx] = array[currIndx + 1];
            }
            array[array.Length - 1] = firstNum;
        }
    }
}

