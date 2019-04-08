using System;


class GameStore
{
    static void Main(string[] args)
    {
        decimal balance = decimal.Parse(Console.ReadLine());
        decimal spent = 0.0m;

        string currInput = Console.ReadLine();

        while (currInput != "Game Time")
        {
            decimal gamePrice = 0m;
            gamePrice = getPrice(currInput);
            if (gamePrice == 0m)
            {
                Console.WriteLine("Not Found");
                currInput = Console.ReadLine();
                continue;
            }

            if(balance >= gamePrice)
            {
                balance -= gamePrice;
                spent += gamePrice;
                Console.WriteLine($"Bought {currInput}");
                if(balance == 0.0m)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Too Expensive");
            }

            currInput = Console.ReadLine();
        }
        Console.WriteLine($"Total spent: ${spent:f2}. Remaining: ${balance:f2}");

    }

    private static decimal getPrice(string currInput)
    {
        if (currInput == "OutFall 4")
        {
            return 39.99m;
        }
        else if(currInput == "CS: OG")
        {
            return 15.99m;
        }
        else if(currInput == "Zplinter Zell")
        {
            return 19.99m;
        }
        else if(currInput == "Honored 2")
        {
            return 59.99m;
        }
        else if(currInput == "RoverWatch")
        {
            return 29.99m;
        }
        else if(currInput == "RoverWatch Origins Edition")
        {
            return 39.99m;
        }
        return 0.0m;
    }
}

