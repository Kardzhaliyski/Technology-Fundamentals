using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativeAndReverse
{
    class RemoveNegativeAndReverse
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> negativeNumbers = GetNegativeNumbers(numbers);
            foreach (var number in negativeNumbers)
            {

            }
            Console.WriteLine(string.Join(' ', negativeNumbers));
            

        }
        static List<int> GetNegativeNumbers(List<int> numbers)
        {
            List<int> negativeNumbers = new List<int>();
            foreach (var num in numbers)
            {
                if(num < 0)
                {
                    negativeNumbers.Add(num);
                }
            }
            return negativeNumbers;
        }
    }
}
