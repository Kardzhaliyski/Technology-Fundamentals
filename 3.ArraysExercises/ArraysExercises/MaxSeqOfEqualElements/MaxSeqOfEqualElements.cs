using System;
using System.Linq;

class MaxSeqOfEqualElements
{
    static void Main(string[] args)
    {
        int[] array = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        PrintHighestSeqOfEqualNumbers(array);

    }

    private static void PrintHighestSeqOfEqualNumbers(int[] array)
    {
        string highestString = array[0] + " ";
        int highestCount = 1;
        int higestNum = array[0];
        string tempString = array[0] + " ";
        int tempCount = 1;
        int tempNum = array[0];


        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == tempNum)
            {
                tempCount++;
                tempString += array[i] + " ";
                if (tempCount > highestCount)
                {
                    highestCount = tempCount;
                    higestNum = tempNum;
                    highestString = tempString;
                }
            }
            else
            {
                tempCount = 1;
                tempString = array[i] + " ";
                tempNum = array[i];
            }
        }
        Console.WriteLine(highestString);
    }
}

