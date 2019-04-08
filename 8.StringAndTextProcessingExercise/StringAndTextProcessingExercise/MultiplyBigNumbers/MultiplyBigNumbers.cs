using System;

namespace MultiplyBigNumbers
{
    class MultiplyBigNumbers
    {
        static void Main(string[] args)
        {
            string bigNum = Console.ReadLine();
            string newBigNum = bigNum;
            int multiplier = int.Parse(Console.ReadLine());
            string newNumber = "";
            int lastNumResidue = 0;

            for (int i = 0; i < bigNum.Length; i++)
            {
                if (bigNum[i] != '0')
                {
                    break;
                }

                else if (i == bigNum.Length - 1 && bigNum[i] == '0')
                {
                    Console.WriteLine(0);
                    return;
                }

                else
                {
                    newBigNum = bigNum.Replace("0","");
                }
            }

            bigNum = newBigNum;

            if (multiplier == 0)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = bigNum.Length - 1; i >= 0; i--)
            {
                int currNum = int.Parse(bigNum[i].ToString());
                int multiplyedNum = currNum * multiplier + lastNumResidue;
                if (multiplyedNum > 10)
                {
                    lastNumResidue = multiplyedNum / 10;
                    multiplyedNum %= 10;
                }

                else
                {
                    lastNumResidue = 0;
                }

                newNumber = multiplyedNum + newNumber;
            }

            if (lastNumResidue > 0)
            {
                newNumber = lastNumResidue + newNumber;
            }

            Console.WriteLine(newNumber);


        }
    }
}
