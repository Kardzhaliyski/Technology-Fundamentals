using System;
using System.Linq;

namespace SumEvenNumbers
{
    class SumEvenNumbers
    {
        static void Main(string[] args)
        {
            int[] arrInts = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            PrintEvenNumbersSum(arrInts);

        }

        public static void PrintEvenNumbersSum(int[] array)
        {
            int evenSum = SumEvenNumbersInArray(array);
            Console.WriteLine(evenSum);
        }

        public static int SumEvenNumbersInArray(int[] array)
        {
            int sum = 0;
            foreach (var num in array)
            {
                if(num % 2 == 0)
                {
                    sum += num;
                }
            }

            return sum;
        }
    }
}
