using System;

namespace MathPower
{
    class MathPower
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            number = GetOnPower(number, power);
            Console.WriteLine(number);

        }

        public static double GetOnPower(double number,int power)
        {
            double currentNumber = number;
            for (int i = 0; i < power -1; i++)
            {
                currentNumber *= number;
            }
            return currentNumber;
        }
    }
}
