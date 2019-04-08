using System;

namespace Calculations
{
    class Calculations
    {
        static void Main(string[] args)
        {
            string actionType = Console.ReadLine();

            if (actionType.ToLower() == "add") AddAndPrint();
            else if (actionType.ToLower() == "subtract") SubtractAndPrint();
            else if (actionType.ToLower() == "multiply") MultiplyAndPrint();
            else if (actionType.ToLower() == "divide") DivideAndPrint();


        }
        public static void AddAndPrint()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1+num2);
        }
        public static void SubtractAndPrint()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1 - num2);
        }
        public static void MultiplyAndPrint()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1 * num2);
        }
        public static void DivideAndPrint()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1 / num2);
        }
    }
}
