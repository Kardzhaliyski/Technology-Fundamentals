using System;
using System.Linq;
using System.Collections.Generic;


namespace CountTheRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Dictionary<double, int> numberCount = new Dictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!numberCount.ContainsKey(number))
                {
                    numberCount[number] = 0;
                }
                numberCount[number]++;
            }
            numberCount = numberCount
                .OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in numberCount)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }


        }
    }
}
