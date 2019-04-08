using System;

namespace TopNumber
{
    class TopNumber
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= endNumber; i++)
            {
                if(ContainAnOddNumber(i) && DigitSumDividableByEigth(i))
                {
                    Console.WriteLine(i);
                }
            }

        }


        public static bool ContainAnOddNumber(int number)
        {
            while(number > 0)
            {
                if(number % 10 % 2 == 1)
                {
                    return true;
                }
                number /= 10;
            }
            return false;

        }
        
        public static bool DigitSumDividableByEigth(int number)
        {
            int sum = GetSumOfDigits(number);
            if(sum % 8 == 0)
            {
                return true;
            }

            return false;
        }

        public static int GetSumOfDigits (int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
    }
}
