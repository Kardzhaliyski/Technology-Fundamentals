using System;

namespace SignOfIntegerNumber
{
    class SignOfIntegerNumber
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            PrintSignOfNumber(num);

        }

        public static void PrintSignOfNumber(int num)
        {
            if(num > 0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else if(num == 0)
            {
                Console.WriteLine($"The number {num} is zero.");
            }
            else
            {
                Console.WriteLine($"The number {num} is negative.");
            }
        }
    }
}
