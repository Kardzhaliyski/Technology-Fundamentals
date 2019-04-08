using System;

namespace SpecialNumber
{
    class SpecialNumber
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                int curSum = 0;
                int curNum = i;

                while(curNum > 0)
                {
                    curSum += curNum % 10;
                    curNum = curNum / 10;
                }
                
                if(curSum == 5 || curSum == 7 || curSum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }

        }
    }
}
