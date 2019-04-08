using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArrays
{
    class AppendArrays
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> arrayStrings = input
                .Split('|')
                .ToList();

            int[][] numbersArr = new int[arrayStrings.Count][];

            for (int i = 0; i < arrayStrings.Count; i++)
            {
                numbersArr[i] = arrayStrings[i]
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            numbersArr = ReverseArray(numbersArr);

            for (int i = 0; i < numbersArr.Length; i++)
            {
                Console.Write(string.Join(' ',numbersArr[i]) + " ");
            }

            
        }

        static int[][] ReverseArray(int[][]array)
        {
            int[][] reverseArray = new int[array.Length][];

            for (int i = 0; i < array.Length; i++)
            {
                reverseArray[i] = array[array.Length - 1 - i];
            }
            return reverseArray;
        }
    }
}
