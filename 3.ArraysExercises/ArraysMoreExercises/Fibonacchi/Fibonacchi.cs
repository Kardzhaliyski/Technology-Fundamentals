using System;
using System.Numerics;

class Fibonacchi
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int fibIndex = int.Parse(input);
        if(fibIndex == 1)
        {
            fibIndex = 2;
        }

        BigInteger[] fibTable = new BigInteger[fibIndex];
            fibTable[0] = 1;
            fibTable[1] = 1;
            for (int i = 2; i < fibTable.Length; i++)
            {
                fibTable[i] = (fibTable[i - 1]) + (fibTable[i - 2]);
            }
            Console.WriteLine(fibTable[fibIndex - 1]);
        
    }
}

