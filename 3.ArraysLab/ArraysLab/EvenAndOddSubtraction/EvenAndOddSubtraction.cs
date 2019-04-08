using System;
using System.Linq;

namespace EvenAndOddSubtraction
{
    class EvenAndOddSubtraction
    {
        static void Main(string[] args)
        {
            int[] arrInts = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(SumOfEvenNumbers(arrInts) - SumOfOddNumbers(arrInts));


        }

        public static int SumOfEvenNumbers(int[] array)
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

        public static int SumOfOddNumbers(int[] array)
        {
            int sum = 0;
            foreach (var num in array)
            {
                if (num % 2 == 1)
                {
                    sum += num;
                }
            }
            return sum;
        }
    }
}
