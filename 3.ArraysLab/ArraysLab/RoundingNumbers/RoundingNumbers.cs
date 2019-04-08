using System;
using System.Linq;

namespace RoundingNumbers
{
    class RoundingNumbers
    {
        static void Main(string[] args)
        {
            double[] arrNums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            foreach (var num in arrNums)
            {
                int roundedNum = (int)Math.Round(num, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{num} => {roundedNum}");
            }
        }
    }
}
