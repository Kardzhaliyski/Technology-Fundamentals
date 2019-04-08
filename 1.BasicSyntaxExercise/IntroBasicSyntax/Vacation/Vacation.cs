using System;


class Vacation
{
    static void Main(string[] args)
    {
        int numOfPeople = int.Parse(Console.ReadLine());
        string groupType = Console.ReadLine();
        string day = Console.ReadLine();

        double price = 0;
        double totalPrice = 0;

        if(groupType.ToLower() == "students")
        {
            if(day.ToLower() == "friday")
            {
                price = 8.45;
            }
            else if(day.ToLower() == "saturday")
            {
                price = 9.8;
            }
            else if(day.ToLower() == "sunday")
            {
                price = 10.46;
            }
        }
        else if (groupType.ToLower() == "business")
        {
            if (day.ToLower() == "friday")
            {
                price = 10.90;
            }
            else if (day.ToLower() == "saturday")
            {
                price = 15.6;
            }
            else if (day.ToLower() == "sunday")
            {
                price = 16;
            }

            if(numOfPeople >= 100)
            {
                numOfPeople -= 10;
            }
        }
        else if (groupType.ToLower() == "regular")
        {
            if (day.ToLower() == "friday")
            {
                price = 15;
            }
            else if (day.ToLower() == "saturday")
            {
                price = 20;
            }
            else if (day.ToLower() == "sunday")
            {
                price = 22.5;
            }
        }

        totalPrice = price * numOfPeople;

        if(groupType.ToLower() == "students" && numOfPeople >= 30)
        {
            totalPrice *= 0.85;
        }
        else if(groupType.ToLower() == "regular" && numOfPeople >= 10 && numOfPeople <= 20)
        {
            totalPrice *= 0.95;
        }

        Console.WriteLine($"Total price: {totalPrice:F2}");

    }
}
