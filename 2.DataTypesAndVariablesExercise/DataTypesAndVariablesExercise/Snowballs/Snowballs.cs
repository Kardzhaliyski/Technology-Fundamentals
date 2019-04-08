using System;
using System.Numerics;

class Snowballs
{
    static void Main(string[] args)
    {
        int nSnowballs = int.Parse(Console.ReadLine());
        BigInteger bestValue = 0;
        int bestSnow = 0;
        int bestTime = 0;
        int bestQuality = 0;


        for (int i = 0; i < nSnowballs; i++)
        {
            int snowballSnow = int.Parse(Console.ReadLine());
            int snowballTime = int.Parse(Console.ReadLine());
            int snowballQuality = int.Parse(Console.ReadLine());
            BigInteger tempValue = snowballSnow / snowballTime;
            tempValue = BigInteger.Pow(tempValue, snowballQuality);

            if (tempValue > bestValue)
            {
                bestValue = tempValue;
                bestSnow = snowballSnow;
                bestTime = snowballTime;
                bestQuality = snowballQuality;
            }
        }
        Console.WriteLine($"{bestSnow} : {bestTime} = {bestValue} ({bestQuality})");
    }

    
}

