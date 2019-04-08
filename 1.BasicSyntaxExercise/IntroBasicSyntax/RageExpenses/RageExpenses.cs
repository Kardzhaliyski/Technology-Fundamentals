using System;


class RageExpenses
{
    static void Main(string[] args)
    {
        int lostGames = int.Parse(Console.ReadLine());
        decimal headsetPrice = decimal.Parse(Console.ReadLine());
        decimal mousePrice = decimal.Parse(Console.ReadLine());
        decimal keyboardPrice = decimal.Parse(Console.ReadLine());
        decimal displayPrice = decimal.Parse(Console.ReadLine());

        decimal totalExpenses = (lostGames / 2 * headsetPrice) + (lostGames / 3 * mousePrice) + (lostGames / 6 * keyboardPrice) + (lostGames / 12 * displayPrice);
        Console.WriteLine($"Rage expenses: {totalExpenses:f2} lv.");




    }
}

