using System;
using System.Collections.Generic;
using System.Linq;

namespace GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            SumOppositeNumbers(numbers);
            Console.WriteLine(string.Join(' ', numbers));

        }

        public static void SumOppositeNumbers(List<int> numbers)
        {
            int firstNumbersCount = numbers.Count;
            for (int currIndex = 0; currIndex < firstNumbersCount / 2; currIndex++)
            {
                numbers[currIndex] += numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
            }
        }
    }
}
