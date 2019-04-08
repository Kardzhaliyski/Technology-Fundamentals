using System;


class ConventorPoundsToDollars
{
    static void Main(string[] args)
    {
        decimal gbp = decimal.Parse(Console.ReadLine());
        decimal usd = gbp * 1.31m;
        Console.WriteLine($"{usd:f3}");
    }
}

