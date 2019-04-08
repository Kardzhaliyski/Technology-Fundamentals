using System;
using System.Linq;

class LongestIncreasingSubsequence
{
    static void Main(string[] args)
    {
        int[] nums = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        int[] len = new int[nums.Length];
        int[] prev = new int[nums.Length];

        int maxLenValue = 0;
        int maxLenIndex = 0;

        for (int currIndex = 0; currIndex < nums.Length; currIndex++)
        {
            bool lowerFound = false;
            int currBestLen = 0;
            int currBestPrevIndex = -1;
            int tempLen = 0;
            int tempPrevIndex = -1;

            for (int prevIndex = currIndex - 1; prevIndex >= 0; prevIndex--)
            {
                if(nums[prevIndex] < nums[currIndex])
                {
                    lowerFound = true;
                    tempLen = len[prevIndex] + 1;
                    tempPrevIndex = prevIndex;

                    if(tempLen > currBestLen)
                    {
                        currBestLen = tempLen;
                        currBestPrevIndex = tempPrevIndex;
                    }
                }
            }
            for (int prevIndex = 0; prevIndex < currBestPrevIndex; prevIndex++)
            {
                if (nums[prevIndex] < nums[currIndex])
                {
                    lowerFound = true;
                    tempLen = len[prevIndex] + 1;
                    tempPrevIndex = prevIndex;

                    if (tempLen == currBestLen)
                    {
                        currBestLen = tempLen;
                        currBestPrevIndex = tempPrevIndex;
                    }
                }
            }

            if (!lowerFound)
            {
                currBestLen = 1;
                currBestPrevIndex = -1;
            }

            len[currIndex] = currBestLen;
            prev[currIndex] = currBestPrevIndex;
            if(currBestLen > maxLenValue)
            {
                maxLenValue = currBestLen;
                maxLenIndex = currIndex;
            }
        }

        string print = "";
        for (int i = maxLenIndex; i >= 0; i = prev[i])
        {
            print = nums[i] + " " + print;
        }
        Console.WriteLine(print);
        
    }
}

