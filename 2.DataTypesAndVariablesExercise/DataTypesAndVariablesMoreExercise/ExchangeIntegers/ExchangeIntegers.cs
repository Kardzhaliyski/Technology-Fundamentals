using System;

namespace ExchangeIntegers
{
    class ExchangeIntegers
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Before:");
            Console.WriteLine($"a = {num1}");
            Console.WriteLine($"b = {num2}");
            Console.WriteLine("After:");
            Console.WriteLine($"a = {num2}");
            Console.WriteLine($"b = {num1}");


        }
    }
}
