using System;


class TribonacciSequence
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());
        PrintTribonacciNumbers(count);

    }

    public static void PrintTribonacciNumbers(int count)
    {
        int[] tribonacciNumbersArr = new int[count];
        GetTribonacchiArray(count, tribonacciNumbersArr);

        Console.WriteLine(string.Join(' ', tribonacciNumbersArr));
    }

    private static void GetTribonacchiArray(int count, int[] array)
    {
        if (array.Length >= 1)
        {
            array[0] = 1;
        }
        if (array.Length >= 2)
        {
            array[1] = 1;
        }
        if (array.Length >= 3)
        {
            array[2] = 2;
        }

        for (int i = 3; i < count; i++)
        {
            array[i] = array[i - 1] + array[i - 2] + array[i - 3];
        }
    }


}

