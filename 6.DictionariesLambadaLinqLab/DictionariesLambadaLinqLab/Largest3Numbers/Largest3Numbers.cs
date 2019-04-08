using System;
using System.Collections.Generic;
using System.Linq;

namespace Largest3Numbers
{
    class Largest3Numbers
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            List<int> largest3Numbers = numbers
                .OrderBy(x => x)
                .Reverse()
                .Take(3)
                .ToList();

            Console.WriteLine(string.Join(' ', largest3Numbers));
        }
    }
}
