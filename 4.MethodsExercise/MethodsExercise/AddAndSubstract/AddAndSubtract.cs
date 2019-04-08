using System;

namespace AddAndSubstract
{
    class AddAndSubtract
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int result = Sum(num1, num2);
            result = Subtract(result, num3);
            Console.WriteLine(result);
        }

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }


    }
}
