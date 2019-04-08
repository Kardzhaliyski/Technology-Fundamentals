using System;

namespace MathOperations
{
    class MathOperations
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            char inputOperator = char.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            double result = Calculate(num1, inputOperator, num2);
            Console.WriteLine(result);
        }

        public static double Calculate(double num1,char charOperator,double num2)
        {
            double result = 0;
            if(charOperator == '+')
            {
                result = CalculateAddition(num1, num2);
            }
            else if(charOperator == '-')
            {
                result = CalculateSubtraction(num1, num2);
            }
            else if(charOperator == '*')
            {
                result = CalculateMultiply(num1, num2);
            }
            else if(charOperator == '/')
            {
                result = CalculateDivision(num1, num2);
            }
            return Math.Round(result, 2);
        }
        
        public static double CalculateAddition(double num1 , double num2)
        {
            return num1 + num2;
        }
        
        public static double CalculateSubtraction(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double CalculateMultiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double CalculateDivision(double num1, double num2)
        {
            return num1 / num2;
        }



    }
}
