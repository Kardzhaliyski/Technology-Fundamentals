using System;

namespace PartyProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int partySize = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int totalCoins = 0;

            for (int currDay = 1; currDay <= days; currDay++)
            {
                if (currDay % 10 == 0)
                {
                    partySize -= 2;
                }
                if (currDay % 15 == 0)
                {
                    partySize += 5;
                }

                totalCoins +=  50 - (2 * partySize);
                if (currDay % 3 == 0)
                {
                    totalCoins -= 3 * partySize;
                }
                if (currDay % 5 == 0)
                {
                    totalCoins += 20 * partySize;
                    if (currDay % 3 == 0)
                    {
                        totalCoins -= 2 * partySize;
                    }
                }

            }

            Console.WriteLine($"{partySize} companions received {totalCoins / partySize} coins each.");


        }
    }
}
