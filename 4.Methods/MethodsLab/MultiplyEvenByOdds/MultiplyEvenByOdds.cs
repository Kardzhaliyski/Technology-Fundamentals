using System;

namespace MultiplyEvenByOdds
{
    class MultiplyEvenByOdds
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            int result = GetMultipleOfEvenAndOdds(inputNum);
            Console.WriteLine(result);

        }

        public static int GetMultipleOfEvenAndOdds(int number)
        {
            number = GetAbs(number);
            int evenDigitsSum = GetSumOfEvenDigits(number);
            int oddDigitsSum = GetSumOfOddDigits(number);
            return evenDigitsSum * oddDigitsSum;
            
        }
        public static int GetSumOfOddDigits(int number)
        {
            int tempNum = number;
            int sum = 0;
            for (int i = 0; i < number.ToString().Length; i++)
            {
                int currNum = tempNum % 10;
                if (currNum % 2 == 1)
                {
                    sum += currNum;
                }
                tempNum = tempNum / 10;
            }
            return sum;
        }

        public static int GetSumOfEvenDigits(int number)
        {
            int tempNum = number;
            int sum = 0;
            for (int i = 0; i < number.ToString().Length; i++)
            {
                int currNum = tempNum % 10;
                if(currNum % 2 ==  0)
                {
                    sum += currNum;
                }
                tempNum = tempNum / 10;
            }
            return sum;

        }

        public static int GetAbs(int number)
        {
            if (number < 0)
            {
                return number * -1;
            }
            else
                return number;
        }
    }
}
