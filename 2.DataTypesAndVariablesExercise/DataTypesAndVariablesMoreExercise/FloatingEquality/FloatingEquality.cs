using System;

namespace FloatingEquality
{
    class FloatingEquality
    {
        static void Main(string[] args)
        {
            double eps = 0.000001;
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            if(Math.Abs(num1 - num2) < eps)
            {
                Console.WriteLine("True");
            }
            else
                Console.WriteLine("False");
        }
    }
}
