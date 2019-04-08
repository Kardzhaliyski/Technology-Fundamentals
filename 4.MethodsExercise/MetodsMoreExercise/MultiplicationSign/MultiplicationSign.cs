using System;

namespace MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();
            string num3 = Console.ReadLine();

            if (IsZero(num1, num2, num3))
            {
                Console.WriteLine("zero");
            }
            else if (IsPositive(num1,num2,num3))
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("negative");
            }
        }

        public static bool IsPositive(string num1, string num2, string num3)
        {
            int minusCounter = 0;
            if (num1[0] == '-')
            {
                minusCounter++;
            }

            if (num2[0] == '-')
            {
                minusCounter++;
            }

            if (num3[0] == '-')
            {
                minusCounter++;
            }

            if(minusCounter % 2 == 1)
            {
                return false;
            }

            return true;
        }


        public static bool IsZero(string num1, string num2, string num3)
        {
            if (num1 == "0" || num2 == "0" || num3 == "0")
            {
                return true;
            }
            return false;
        }
    }
}
