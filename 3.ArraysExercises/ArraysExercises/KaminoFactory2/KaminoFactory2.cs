using System;
using System.Linq;

class KaminoFactory2
{
    static void Main(string[] args)
    {
        int arrayLength = int.Parse(Console.ReadLine());
        int[] lsArr = new int[arrayLength];
        int lsLength = -1;
        int lsFirstIndex = -1;
        int lsArrIndex = 1;
        int lsSum = 0;
        string input = "";
        int currArrIndex = 0;

        while((input = Console.ReadLine()) != "Clone them!")
        {
            int[] array = input
                .Split('!', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            currArrIndex++;

            int tempLength = 0;
            int tempFirstIndex = -1;
            int tempSum = array.Sum();

            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] == 1)
                {
                    if(tempLength == 0)
                    {
                        tempFirstIndex = i;
                    }
                    tempLength++;

                    if(tempLength > lsLength)
                    {
                        lsArr = array;
                        lsLength = tempLength;
                        lsFirstIndex = tempFirstIndex;
                        lsArrIndex = currArrIndex;
                        lsSum = tempSum;
                    }
                    else if(tempLength == lsLength)
                    {
                        if(tempFirstIndex < lsFirstIndex)
                        {
                            lsArr = array;
                            lsLength = tempLength;
                            lsFirstIndex = tempFirstIndex;
                            lsArrIndex = currArrIndex;
                            lsSum = tempSum;
                        }
                        else if(tempFirstIndex == lsFirstIndex && tempSum > lsSum)
                        {
                            lsArr = array;
                            lsLength = tempLength;
                            lsFirstIndex = tempFirstIndex;
                            lsArrIndex = currArrIndex;
                            lsSum = tempSum;
                        }
                    }
                }
                else
                {
                    tempLength = 0;
                    tempFirstIndex = -1;
                }
            }


        }
        

        Console.WriteLine($"Best DNA sample {lsArrIndex} with sum: {lsSum}.");
        Console.WriteLine(string.Join(' ',lsArr));



    }
}

