using System;
using System.Linq;

class KaminoFactory
{
    static void Main(string[] args)
    {
        int dnkLength = int.Parse(Console.ReadLine());

        int bestSum = -1;
        int bestInArrIndex = -1;
        int bestArrIndex = -1;
        int bestArrSeqCounter = -1;
        string bestString = "";
        int currArrIndex = 0;


        string input = Console.ReadLine();

        while(input != "Clone them!")
        {
            int[] array = input
                .Split('!', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            currArrIndex++;
            int currSum = array.Sum();
            int curArrSeqCounter = -1;
            int curArrSeqFirstIndex = -1;
            int tempSeqCounter = 0;
            int tempSeqFirstIndex = 0;
            string tempString = "";

            foreach (var num in array)
            {
                tempString += num + " ";
            }
            
            if(bestString == "")
            {
                bestString = tempString;
            }

            for (int i = 0; i < array.Length; i++)
            {
                

                if(array[i] == 1)
                {
                    tempSeqCounter++;
                    if(tempSeqCounter == 1)
                    {
                        tempSeqFirstIndex = i;
                    }

                    if(tempSeqCounter > curArrSeqCounter)
                    {
                        curArrSeqCounter = tempSeqCounter;
                        curArrSeqFirstIndex = tempSeqFirstIndex;
                    }

                    if (curArrSeqCounter > bestArrSeqCounter)
                    {
                        bestSum = currSum;
                        bestInArrIndex = curArrSeqFirstIndex;
                        bestArrIndex = currArrIndex;
                        bestArrSeqCounter = curArrSeqCounter;
                        bestString = tempString;
                        
                    }
                    else if (curArrSeqCounter == bestArrSeqCounter)
                    {
                        if(curArrSeqFirstIndex < bestInArrIndex)
                        {
                            bestSum = currSum;
                            bestInArrIndex = curArrSeqFirstIndex;
                            bestArrIndex = currArrIndex;
                            bestArrSeqCounter = curArrSeqCounter;
                            bestString = tempString;
                        }
                        else if(curArrSeqFirstIndex == bestInArrIndex && currSum > bestSum)
                        {
                            bestSum = currSum;
                            bestInArrIndex = curArrSeqFirstIndex;
                            bestArrIndex = currArrIndex;
                            bestArrSeqCounter = curArrSeqCounter;
                            bestString = tempString;
                        }
                    }
                }
                else
                {
                    tempSeqCounter = 0;
                    tempSeqFirstIndex = i;
                }
            }

            input = Console.ReadLine();
        }

        Console.WriteLine($"Best DNA sample {bestArrIndex} with sum: {bestSum}.");
        Console.WriteLine($"{bestString}");
        
    }

    
}

