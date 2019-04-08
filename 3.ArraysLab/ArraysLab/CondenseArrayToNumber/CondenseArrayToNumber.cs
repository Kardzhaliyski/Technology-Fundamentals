using System;
using System.Linq;

namespace CondenseArrayToNumber
{
    class CondenseArrayToNumber
    {
        static void Main(string[] args)
        {
            int[] arrNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < arrNumbers.Length - 1; i++)
            {
                for (int currInx = 0; currInx < arrNumbers.Length - 1 - i; currInx++)
                {
                    arrNumbers[currInx] = arrNumbers[currInx] + arrNumbers[currInx + 1];
                }
            }

            Console.WriteLine(arrNumbers[0]);
        }
    }
}
