using System;

namespace SmallestOfThreeNumbers
{
    class SmallestOfThreeNumbers
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine(GetSmallestNumber(num1, num2, num3));
        }


        public static int GetSmallestNumber(int num1, int num2, int num3)
        {
            int smallestNumber = num1;

            if (smallestNumber > num2)
            {
                smallestNumber = num2;
            }

            if (smallestNumber > num3)
            {
                smallestNumber = num3;
            }

            return smallestNumber;
        }
    }
}
