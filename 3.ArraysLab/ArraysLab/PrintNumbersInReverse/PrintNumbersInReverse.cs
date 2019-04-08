using System;

namespace PrintNumbersInReverse
{
    class PrintNumbersInReverse
    {
        static void Main(string[] args)
        {
            int arrLength = int.Parse(Console.ReadLine());
            int[] arrNumbers = new int[arrLength];
            GetArrayFromConsole(arrLength, arrNumbers);
            PrintArrayInReverse(arrNumbers);

        }

        public static void PrintArrayInReverse(int[] arrNumbers)
        {
            for (int i = arrNumbers.Length - 1; i >= 0; i--)
            {
                Console.Write(arrNumbers[i] + " ");
            }
        }

        private static void GetArrayFromConsole(int arrLength, int[] arrNumbers)
        {
            for (int i = 0; i < arrLength; i++)
            {
                arrNumbers[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
