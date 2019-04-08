using System;
using System.Collections.Generic;
using System.Linq;

class PrArrayManipulatorogram
{
    static void Main(string[] args)
    {
        int[] array = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        string input;

        while ((input = Console.ReadLine()) != "end")
        {
            string[] inputArray = input
                .Split();

            if (inputArray[0] == "exchange")
            {
                int exchangeIndex = int.Parse(inputArray[1]);
                if (exchangeIndex >= array.Length || exchangeIndex < 0)
                {
                    Console.WriteLine("Invalid index");
                    continue;
                }

                RotateArrayToLeft(array, exchangeIndex);
            }


            else if (inputArray[0] == "max")
            {
                int expectedRemainder;
                if (inputArray[1] == "even")
                {
                    expectedRemainder = 0;
                }
                else
                {
                    expectedRemainder = 1;
                }
                Console.WriteLine(GetMaxValueIndex(array, expectedRemainder));
            }

            else if (inputArray[0] == "min")
            {
                int expectedRemainder;
                if (inputArray[1] == "even")
                {
                    expectedRemainder = 0;
                }
                else
                {
                    expectedRemainder = 1;
                }
                Console.WriteLine(GetMinValueIndex(array, expectedRemainder));
            }

            else if (inputArray[0] == "first")
            {
                int expectedRemainder;
                int firstNNumbers = int.Parse(inputArray[1]);


                if (firstNNumbers > array.Length)
                {
                    Console.WriteLine("Invalid count");
                    continue;
                }

                if (inputArray[2] == "even")
                {
                    expectedRemainder = 0;
                }

                else
                {
                    expectedRemainder = 1;
                }


                Console.WriteLine("[" + FirstNOddOrEvenNumbers(array, expectedRemainder, firstNNumbers) + "]");
            }

            else if (inputArray[0] == "last")
            {
                int expectedRemainder;
                int firstNNumbers = int.Parse(inputArray[1]);

                if (firstNNumbers > array.Length)
                {
                    Console.WriteLine("Invalid count");
                    continue;
                }

                if (inputArray[2] == "even")
                {
                    expectedRemainder = 0;
                }
                else
                {
                    expectedRemainder = 1;
                }


               Console.WriteLine("[" + LastNOddOrEvenNumbers(array, expectedRemainder, firstNNumbers) + "]");
            }
        }

        Console.WriteLine("[" + string.Join(", ", array) + "]");


    }

    public static void RotateArrayToLeft(int[] array, int times)
    {
        int arrayLength = array.Length;
        for (int currRotation = 0; currRotation <= times; currRotation++)
        {
            int temp = array[0];
            for (int currPosition = 1; currPosition < arrayLength; currPosition++)
            {
                array[currPosition - 1] = array[currPosition];
            }
            array[arrayLength - 1] = temp;
        }

    }

    public static string GetMaxValueIndex(int[] array, int expectedRemainder)
    {
        int currMaxNumber = int.MinValue;
        int currMaxIndex = -1;
        for (int currIndex = 0; currIndex < array.Length; currIndex++)
        {
            if (array[currIndex] % 2 == expectedRemainder)
            {

                if (array[currIndex] >= currMaxNumber)
                {
                    currMaxNumber = array[currIndex];
                    currMaxIndex = currIndex;
                }
            }
        }

        if (currMaxIndex == -1)
        {
            return "No matches";
        }

        return currMaxIndex.ToString();

    }

    public static string GetMinValueIndex(int[] array, int expectedRemainder)
    {
        int currMinNumber = int.MaxValue;
        int currMaxIndex = -1;
        for (int currIndex = 0; currIndex < array.Length; currIndex++)
        {
            if (array[currIndex] % 2 == expectedRemainder)
            {

                if (array[currIndex] <= currMinNumber)
                {
                    currMinNumber = array[currIndex];
                    currMaxIndex = currIndex;
                }
            }
        }

        if (currMaxIndex == -1)
        {
            return "No matches";
        }

        return currMaxIndex.ToString();

    }

    public static string FirstNOddOrEvenNumbers(int[] array, int expectedRemainder, int firstNNumbers)
    {
        List<int> firstNumbers = new List<int>();

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == expectedRemainder)
            {
                firstNumbers.Add(array[i]);
            }

            if (firstNumbers.Count >= firstNNumbers)
            {
                return string.Join(", ", firstNumbers);
            }
        }

        return string.Join(", ", firstNumbers);

    }

    public static string LastNOddOrEvenNumbers(int[] array, int expectedRemainder, int firstNNumbers)
    {
        List<int> lastNumbers = new List<int>();

        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] % 2 == expectedRemainder)
            {
                lastNumbers.Add(array[i]);
            }

            if (lastNumbers.Count >= firstNNumbers)
            {
                lastNumbers.Reverse();
                return string.Join(", ", lastNumbers);
            }
        }
        lastNumbers.Reverse();
        return string.Join(", ", lastNumbers);
    }
}