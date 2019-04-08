using System;
using System.Collections.Generic;

class FactorialDivision
{
    static void Main()
    {
        List<long> factorials = new List<long> { 1 };
        int firstFactorialIndex = int.Parse(Console.ReadLine());
        int secoundFactorialIndex = int.Parse(Console.ReadLine());

        FindFactorials(factorials, firstFactorialIndex);
        FindFactorials(factorials, secoundFactorialIndex);

        double result = (double)factorials[firstFactorialIndex] / factorials[secoundFactorialIndex];

        Console.WriteLine($"{result:f2}");
    }

    private static void FindFactorials(List<long> factorialList, int factorialIndex)
    {
        for (int i = factorialList.Count; i <= factorialIndex; i++)
        {
            factorialList.Add(factorialList[i - 1] * i);
        }
        
    }
}

